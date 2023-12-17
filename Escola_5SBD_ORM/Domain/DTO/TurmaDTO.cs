using Escola_5SBD_ORM.Domain.DTO._Base;
using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.DTO
{
    public class TurmaDTO : BaseDTO
    {
        public int idDisciplina { get; set; }
        public string semestre { get; set; } = null!;
    }
}
