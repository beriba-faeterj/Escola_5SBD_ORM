using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Escola_5SBD_ORM.Domain.Service._Base;

namespace Escola_5SBD_ORM.Domain.Service
{
    public class DisciplinaService : BaseService<Disciplina>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository) : base(disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
        public async Task<Disciplina> GetBySigla(string sigla)
        {
            return await _disciplinaRepository.GetBySigla(sigla);
        }
    }
}
