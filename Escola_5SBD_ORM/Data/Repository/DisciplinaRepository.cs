using Escola_5SBD_ORM.Data.Context;
using Escola_5SBD_ORM.Data.Repository._Base;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Escola_5SBD_ORM.Data.Repository
{
    public class DisciplinaRepository : BaseRepository<EscolaContext, Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository (EscolaContext options) : base(options)
        {

        }
        public async Task<Disciplina> GetBySigla(string sigla)
        {
            return await _databaseContext.Set<Disciplina>().FirstOrDefaultAsync(d => d.sigla == sigla);
        }


    }
}
