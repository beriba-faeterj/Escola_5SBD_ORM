using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Domain.Interface.Repository
{
    public interface ITurma_AlunoRepository : IBaseRepository<Turma_Aluno>
    {
        // preguicinha

        //Task<List<Turma>> GetTurmasByAluno(int idAluno);
        //Task<List<Aluno>> GetAlunosByTurma(int idTurma);
    }
}
