using Escola_5SBD_ORM.Domain.Model._Base;
using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.Model
{
    public class Aluno : BaseModel
    {
        [StringLength(3)]
        [RegularExpression(@"^\d{3}$")]
        public string matricula { get; set; } = null!;

        [StringLength(64)]
        [RegularExpression(@"^[^\s].+[^\s]$")]
        public string nome { get; set; } = null!;
        public DateOnly dataNasc { get; set; }
        public HashSet<Turma_Aluno>? turma_aluno { get; set; } = new HashSet<Turma_Aluno>();
    }
}
