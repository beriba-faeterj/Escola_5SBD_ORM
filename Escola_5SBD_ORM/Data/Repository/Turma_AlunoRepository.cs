using Escola_5SBD_ORM.Data.Context;
using Escola_5SBD_ORM.Data.Repository._Base;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Data.Repository
{
    public class Turma_AlunoRepository : BaseRepository<EscolaContext, Turma_Aluno>, ITurma_AlunoRepository
    {
        public Turma_AlunoRepository(EscolaContext options) : base(options)
        {

        }

        // todo
    }
}
