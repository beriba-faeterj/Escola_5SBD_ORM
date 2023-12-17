using Escola_5SBD_ORM.Domain.Model._Base;

namespace Escola_5SBD_ORM.Domain.Model
{
    public class Turma_Aluno : BaseModel
    {
        public int idTurma { get; set; }
        public Turma? turma { get; set; }
        public int idAluno { get; set; }
        public Aluno? aluno { get; set; }
        public double? av1 { get; set; }
        public double? av2 { get; set; }
        public double? avf { get; set; }
    }
}
