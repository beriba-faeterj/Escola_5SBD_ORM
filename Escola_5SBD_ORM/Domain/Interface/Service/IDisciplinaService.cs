using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Domain.Interface.Service
{
    public interface IDisciplinaService : IBaseRepository<Disciplina>
    {
        Task<Disciplina> GetBySigla(string sigla);
    }
}
