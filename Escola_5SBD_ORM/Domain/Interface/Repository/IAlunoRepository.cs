using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Domain.Interface.Repository
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        Task<Aluno> GetByMatricula(string matr);

        Task<List<Aluno>> GetByNome(string nome);
    }
}
