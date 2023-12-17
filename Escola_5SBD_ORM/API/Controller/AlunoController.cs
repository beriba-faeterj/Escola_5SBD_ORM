using AutoMapper;
using Escola_5SBD_ORM.Data.Context;
using Escola_5SBD_ORM.Domain.DTO;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Escola_5SBD_ORM.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        private readonly IMapper _mapper;

        public AlunoController(IAlunoService alunoService, IMapper mapper)
        {
            _alunoService = alunoService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aluno = await _alunoService.GetById(id);

            if (aluno == null) return NotFound("Aluno não encontrado.");

            var alunoDto = _mapper.Map<AlunoDTO>(aluno);

            return Ok(alunoDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var alunos = await _alunoService.GetAll();

            if (alunos == null || !alunos.Any()) return NotFound("Nenhum aluno encontrado.");

            var alunosDto = _mapper.Map<List<AlunoDTO>>(alunos);

            return Ok(alunosDto);
        }

        [HttpGet]
        [Route("matr/{matr}")]
        public async Task<IActionResult> GetByMatricula(string matr)
        {
            var aluno = await _alunoService.GetByMatricula(matr);

            if (aluno == null) return NotFound("Nenhum aluno encontrado.");

            var alunoDto = _mapper.Map<AlunoDTO>(aluno);

            return Ok(alunoDto);
        }

        [HttpGet]
        [Route("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            var alunos = await _alunoService.GetByNome(nome);

            if (alunos == null || !alunos.Any()) return NotFound("Nenhum aluno encontrado.");
            
            var alunosDto = _mapper.Map<List<AlunoDTO>>(alunos);

            return Ok(alunosDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AlunoCreateDTO alunoDto)
        {
            var novoAluno = _mapper.Map<Aluno>(alunoDto);

            await _alunoService.Create(novoAluno);

            return Ok("Aluno cadastrado com sucesso.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] AlunoDTO alunoDto)
        {
            var aluno = _mapper.Map<Aluno>(alunoDto);

            await _alunoService.Delete(aluno);

            return Ok("Aluno removido com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AlunoDTO alunoDto)
        {
            var aluno = _mapper.Map<Aluno>(alunoDto);

            await _alunoService.Update(aluno);

            return Ok("Aluno atualizado com sucesso.");
        }
    }
}
