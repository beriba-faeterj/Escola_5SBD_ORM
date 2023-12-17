namespace Escola_5SBD_ORM.Domain.DTO
{
    public class Turma_AlunoCreateDTO
    {
        public int idTurma { get; set; }
        public int idAluno { get; set; }
        public double? av1 { get; set; }
        public double? av2 { get; set; }
        public double? avf { get; set; }
    }
}
