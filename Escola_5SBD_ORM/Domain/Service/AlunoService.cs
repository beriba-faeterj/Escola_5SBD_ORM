using Escola_5SBD_ORM.Data.Repository;
using Escola_5SBD_ORM.Domain.Interface.Repository;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Escola_5SBD_ORM.Domain.Service._Base;
using System;

namespace Escola_5SBD_ORM.Domain.Service
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<Aluno> GetByMatricula(string matr)
        {
            return await _alunoRepository.GetByMatricula(matr);
        }

        public async Task<List<Aluno>> GetByNome(string nome)
        {
            return await _alunoRepository.GetByNome(nome);
        }
    }
}
