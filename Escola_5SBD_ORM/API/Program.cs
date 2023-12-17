using Escola_5SBD_ORM.Data.Converters;
using Escola_5SBD_ORM.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Service;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IDisciplinaService, DisciplinaService>();
builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
builder.Services.AddScoped<ITurmaService, TurmaService>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<ITurma_AlunoService, Turma_AlunoService>();
builder.Services.AddScoped<ITurma_AlunoRepository, Turma_AlunoRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddJsonOptions(
    options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
    }
);

//var con = builder.Configuration["ConnectionStrings:mysql"];
var con = "Server=localhost;Port=3306;Database=escola_orm;User=root;Password=123456";

builder.Services.AddDbContext<EscolaContext>(options =>
    options.UseMySql(con, ServerVersion.AutoDetect(con))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
