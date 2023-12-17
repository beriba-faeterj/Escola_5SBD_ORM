using Escola_5SBD_ORM.Data.Context;
using Escola_5SBD_ORM.Data.Repository._Base;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Escola_5SBD_ORM.Data.Repository
{
    public class AlunoRepository : BaseRepository<EscolaContext, Aluno>, IAlunoRepository
    {
        public AlunoRepository(EscolaContext options) : base(options)
        {

        }
        public async Task<Aluno> GetByMatricula(string matr)
        {
            return await _databaseContext.Set<Aluno>().FirstOrDefaultAsync(a => a.matricula == matr);
        }

        public async Task<List<Aluno>> GetByNome(string nome)
        {
            return await _databaseContext.Set<Aluno>().Where(a => a.nome == nome).ToListAsync();
        }
    }
}
