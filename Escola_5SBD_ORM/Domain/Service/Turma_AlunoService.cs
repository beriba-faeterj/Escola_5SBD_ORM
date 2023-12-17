using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Escola_5SBD_ORM.Domain.Service._Base;

namespace Escola_5SBD_ORM.Domain.Service
{
    public class Turma_AlunoService : BaseService<Turma_Aluno>, ITurma_AlunoService
    {
        private readonly ITurma_AlunoRepository _turmaAlunoRepository;

        public Turma_AlunoService(ITurma_AlunoRepository turmaAlunoRepository) : base(turmaAlunoRepository)
        {
            _turmaAlunoRepository = turmaAlunoRepository;
        }

        // todo
    }
}
