using Escola_5SBD_ORM.Data.Context;
using Escola_5SBD_ORM.Data.Repository._Base;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Escola_5SBD_ORM.Data.Repository
{
    public class TurmaRepository : BaseRepository<EscolaContext, Turma>, ITurmaRepository
    {
        public TurmaRepository(EscolaContext options) : base(options)
        {

        }

        public async Task<List<Turma>> GetByDisciplina(int idDisciplina)
        {
            
            return await _databaseContext.Set<Turma>().Where(t => t.idDisciplina == idDisciplina).ToListAsync();
        }
    }
}
