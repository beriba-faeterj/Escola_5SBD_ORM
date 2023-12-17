namespace Escola_5SBD_ORM.Domain.DTO
{
    public class AlunoCreateDTO
    {
        public string matricula { get; set; } = null!;
        public string nome { get; set; } = null!;
        public DateOnly dataNasc { get; set; }
    }
}
