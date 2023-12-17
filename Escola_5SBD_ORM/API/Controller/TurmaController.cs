using AutoMapper;
using Escola_5SBD_ORM.Domain.DTO;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Escola_5SBD_ORM.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _turmaService;
        private readonly IMapper _mapper;

        public TurmaController(ITurmaService turmaService, IMapper mapper)
        {
            _turmaService = turmaService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var turma = await _turmaService.GetById(id);

            if (turma == null) return NotFound("Turma não encontrado.");

            var turmaDto = _mapper.Map<TurmaDTO>(turma);

            return Ok(turmaDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var turmas = await _turmaService.GetAll();

            if (turmas == null || !turmas.Any()) return NotFound("Nenhum turma encontrado.");

            var turmasDto = _mapper.Map<List<TurmaDTO>>(turmas);

            return Ok(turmasDto);
        }

        [HttpGet]
        [Route("disc/{idDisciplina}")]
        public async Task<IActionResult> GetByDisciplina(int idDisciplina)
        {
            var turmas = await _turmaService.GetByDisciplina(idDisciplina);

            if (turmas == null) return NotFound("Nenhum turma encontrado.");

            var turmasDto = _mapper.Map<List<TurmaDTO>>(turmas);

            return Ok(turmasDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TurmaCreateDTO turmaDto)
        {
            var novoTurma = _mapper.Map<Turma>(turmaDto);

            await _turmaService.Create(novoTurma);

            return Ok("Turma cadastrado com sucesso.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] TurmaDTO turmaDto)
        {
            var turma = _mapper.Map<Turma>(turmaDto);

            await _turmaService.Delete(turma);

            return Ok("Turma removido com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TurmaDTO turmaDto)
        {
            var turma = _mapper.Map<Turma>(turmaDto);

            await _turmaService.Update(turma);

            return Ok("Turma atualizado com sucesso.");
        }
    }
}
