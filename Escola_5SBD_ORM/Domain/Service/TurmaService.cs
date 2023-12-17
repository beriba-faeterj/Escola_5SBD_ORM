using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Escola_5SBD_ORM.Domain.Service._Base;

namespace Escola_5SBD_ORM.Domain.Service
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaService(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        public async Task<List<Turma>> GetByDisciplina(int idDisciplina)
        {
            return await _turmaRepository.GetByDisciplina(idDisciplina);
        }
    }
}
