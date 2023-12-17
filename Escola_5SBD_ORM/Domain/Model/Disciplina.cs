using Escola_5SBD_ORM.Domain.Model._Base;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.Model
{
    public class Disciplina : BaseModel
    {

        [StringLength(64)]
        [RegularExpression(@"^[^\s].+[^\s]$")]
        public string nome { get; set; } = null!;

        [StringLength(4)]
        [RegularExpression(@"^\d[A-Za-z]{3}$")]
        public string sigla { get; set; } = null!;
        public HashSet<Turma>? turmas { get; set; } = new HashSet<Turma>();
    }
}