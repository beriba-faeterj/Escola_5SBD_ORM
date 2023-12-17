using AutoMapper;
using Escola_5SBD_ORM.Domain.DTO;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Escola_5SBD_ORM.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Turma_AlunoController : ControllerBase
    {
        private readonly ITurma_AlunoService _turmaAlunoService;
        private readonly IMapper _mapper;

        public Turma_AlunoController(ITurma_AlunoService turmaAlunoService, IMapper mapper)
        {
            _turmaAlunoService = turmaAlunoService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var turmaAluno = await _turmaAlunoService.GetById(id);

            if (turmaAluno == null) return NotFound("Turma_Aluno não encontrado.");

            var turmaAlunoDto = _mapper.Map<Turma_AlunoDTO>(turmaAluno);

            return Ok(turmaAlunoDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var turmaAlunos = await _turmaAlunoService.GetAll();

            if (turmaAlunos == null || !turmaAlunos.Any()) return NotFound("Nenhum turmaAluno encontrado.");

            var listaTurma_AlunoDto = _mapper.Map<List<Turma_AlunoDTO>>(turmaAlunos);

            return Ok(listaTurma_AlunoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Turma_AlunoCreateDTO turmaAlunoDto)
        {
            var novoTurma_Aluno = _mapper.Map<Turma_Aluno>(turmaAlunoDto);

            await _turmaAlunoService.Create(novoTurma_Aluno);

            return Ok("Turma_Aluno cadastrado com sucesso.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Turma_AlunoDTO turmaAlunoDto)
        {
            var turmaAluno = _mapper.Map<Turma_Aluno>(turmaAlunoDto);

            await _turmaAlunoService.Delete(turmaAluno);

            return Ok("Turma_Aluno removido com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Turma_AlunoDTO turmaAlunoDto)
        {
            var turmaAluno = _mapper.Map<Turma_Aluno>(turmaAlunoDto);

            await _turmaAlunoService.Update(turmaAluno);

            return Ok("Turma_Aluno atualizado com sucesso.");
        }
    }
}
