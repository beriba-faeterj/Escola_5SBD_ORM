using Escola_5SBD_ORM.Domain.DTO._Base;
using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.DTO
{
    public class DisciplinaDTO : BaseDTO
    {
        public string nome { get; set; } = null!;
        public string sigla { get; set; } = null!;
    }
}
