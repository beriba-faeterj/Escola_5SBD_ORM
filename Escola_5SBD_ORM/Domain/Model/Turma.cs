using Escola_5SBD_ORM.Domain.Model._Base;
using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.Model
{
    public class Turma : BaseModel
    {
        public int idDisciplina { get; set; }

        [StringLength(6)]
        [RegularExpression(@"^\d{4}\.\d$")]
        public string semestre { get; set; } = null!;

        public Disciplina? disciplina { get; set; }

        // turno
        public HashSet<Turma_Aluno>? turma_aluno { get; set; } = new HashSet<Turma_Aluno>();
    }
}
