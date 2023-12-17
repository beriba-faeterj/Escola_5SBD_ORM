using AutoMapper;
using Escola_5SBD_ORM.Domain.DTO;
using Escola_5SBD_ORM.Domain.Interface.Service;
using Escola_5SBD_ORM.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Escola_5SBD_ORM.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;
        private readonly IMapper _mapper;

        public DisciplinaController(IDisciplinaService disciplinaService, IMapper mapper)
        {
            _disciplinaService = disciplinaService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var disciplina = await _disciplinaService.GetById(id);

            if (disciplina == null) return NotFound("Disciplina não encontrado.");

            var disciplinaDto = _mapper.Map<DisciplinaDTO>(disciplina);

            return Ok(disciplinaDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var disciplinas = await _disciplinaService.GetAll();

            if (disciplinas == null || !disciplinas.Any()) return NotFound("Nenhum disciplina encontrado.");

            var disciplinasDto = _mapper.Map<List<DisciplinaDTO>>(disciplinas);

            return Ok(disciplinasDto);
        }

        [HttpGet]
        [Route("sigla/{sigla}")]
        public async Task<IActionResult> GetBySigla(string sigla)
        {
            var disciplina = await _disciplinaService.GetBySigla(sigla);

            if (disciplina == null) return NotFound("Nenhum disciplina encontrado.");

            var disciplinaDto = _mapper.Map<DisciplinaDTO>(disciplina);

            return Ok(disciplinaDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DisciplinaCreateDTO disciplinaDto)
        {
            var novoDisciplina = _mapper.Map<Disciplina>(disciplinaDto);

            await _disciplinaService.Create(novoDisciplina);

            return Ok("Disciplina cadastrado com sucesso.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DisciplinaDTO disciplinaDto)
        {
            var disciplina = _mapper.Map<Disciplina>(disciplinaDto);

            await _disciplinaService.Delete(disciplina);

            return Ok("Disciplina removido com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] DisciplinaDTO disciplinaDto)
        {
            var disciplina = _mapper.Map<Disciplina>(disciplinaDto);

            await _disciplinaService.Update(disciplina);

            return Ok("Disciplina atualizado com sucesso.");
        }
    }
}
