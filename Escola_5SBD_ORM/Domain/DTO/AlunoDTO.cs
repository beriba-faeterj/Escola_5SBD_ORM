using Escola_5SBD_ORM.Domain.DTO._Base;

namespace Escola_5SBD_ORM.Domain.DTO
{
    public class AlunoDTO : BaseDTO
    {
        public string matricula { get; set; } = null!;
        public string nome { get; set; } = null!;
        public DateOnly dataNasc { get; set; }
    }
}
