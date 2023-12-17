using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola_5SBD_ORM.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    matricula = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataNasc = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sigla = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idDisciplina = table.Column<int>(type: "int", nullable: false),
                    semestre = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turma_Disciplina_idDisciplina",
                        column: x => x.idDisciplina,
                        principalTable: "Disciplina",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turma_Aluno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idTurma = table.Column<int>(type: "int", nullable: false),
                    idAluno = table.Column<int>(type: "int", nullable: false),
                    av1 = table.Column<double>(type: "double", nullable: true),
                    av2 = table.Column<double>(type: "double", nullable: true),
                    avf = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma_Aluno", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turma_Aluno_Aluno_idAluno",
                        column: x => x.idAluno,
                        principalTable: "Aluno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turma_Aluno_Turma_idTurma",
                        column: x => x.idTurma,
                        principalTable: "Turma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_idDisciplina",
                table: "Turma",
                column: "idDisciplina");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_Aluno_idAluno",
                table: "Turma_Aluno",
                column: "idAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_Aluno_idTurma",
                table: "Turma_Aluno",
                column: "idTurma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turma_Aluno");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Disciplina");
        }
    }
}
