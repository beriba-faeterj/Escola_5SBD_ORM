﻿// <auto-generated />
using System;
using Escola_5SBD_ORM.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Escola_5SBD_ORM.Data.Migrations
{
    [DbContext(typeof(EscolaContext))]
    [Migration("20231217190309_teste")]
    partial class teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("dataNasc")
                        .HasColumnType("date");

                    b.Property<string>("matricula")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Disciplina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("sigla")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.HasKey("id");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Turma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idDisciplina")
                        .HasColumnType("int");

                    b.Property<string>("semestre")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.HasKey("id");

                    b.HasIndex("idDisciplina");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Turma_Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double?>("av1")
                        .HasColumnType("double");

                    b.Property<double?>("av2")
                        .HasColumnType("double");

                    b.Property<double?>("avf")
                        .HasColumnType("double");

                    b.Property<int>("idAluno")
                        .HasColumnType("int");

                    b.Property<int>("idTurma")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idAluno");

                    b.HasIndex("idTurma");

                    b.ToTable("Turma_Aluno");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Turma", b =>
                {
                    b.HasOne("Escola_5SBD_ORM.Domain.Model.Disciplina", "disciplina")
                        .WithMany("turmas")
                        .HasForeignKey("idDisciplina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("disciplina");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Turma_Aluno", b =>
                {
                    b.HasOne("Escola_5SBD_ORM.Domain.Model.Aluno", "aluno")
                        .WithMany("turma_aluno")
                        .HasForeignKey("idAluno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola_5SBD_ORM.Domain.Model.Turma", "turma")
                        .WithMany("turma_aluno")
                        .HasForeignKey("idTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("turma");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Aluno", b =>
                {
                    b.Navigation("turma_aluno");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Disciplina", b =>
                {
                    b.Navigation("turmas");
                });

            modelBuilder.Entity("Escola_5SBD_ORM.Domain.Model.Turma", b =>
                {
                    b.Navigation("turma_aluno");
                });
#pragma warning restore 612, 618
        }
    }
}