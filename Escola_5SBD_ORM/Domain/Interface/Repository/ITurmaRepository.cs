using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Domain.Interface.Repository
{
    public interface ITurmaRepository : IBaseRepository<Turma>
    {
        Task<List<Turma>> GetByDisciplina(int idDisciplina);
    }
}
