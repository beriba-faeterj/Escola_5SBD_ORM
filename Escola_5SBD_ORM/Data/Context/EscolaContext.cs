using Escola_5SBD_ORM.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Escola_5SBD_ORM.Data.Context
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Turma>()
            .HasOne(t => t.disciplina)
            .WithMany(d => d.turmas)
            .HasForeignKey(t => t.idDisciplina);

            modelBuilder.Entity<Turma_Aluno>()
                .HasOne(ta => ta.turma)
                .WithMany(t => t.turma_aluno)
                .HasForeignKey(ta => ta.idTurma);

            modelBuilder.Entity<Turma_Aluno>()
                .HasOne(ta => ta.aluno)
                .WithMany(a => a.turma_aluno)
                .HasForeignKey(ta => ta.idAluno);
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Turma_Aluno> Turma_Aluno { get; set; }
    }
}
