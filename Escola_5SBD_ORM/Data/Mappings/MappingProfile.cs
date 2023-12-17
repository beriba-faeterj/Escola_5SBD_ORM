using AutoMapper;
using Escola_5SBD_ORM.Domain.DTO;
using Escola_5SBD_ORM.Domain.Model;

namespace Escola_5SBD_ORM.Data.Mappings
{
    public class MappingProfile  : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoDTO>().ReverseMap();
            CreateMap<Aluno, AlunoCreateDTO>().ReverseMap();
            CreateMap<Disciplina, DisciplinaDTO>().ReverseMap();
            CreateMap<Disciplina, DisciplinaCreateDTO>().ReverseMap();
            CreateMap<Turma, TurmaDTO>().ReverseMap();
            CreateMap<Turma, TurmaCreateDTO>().ReverseMap();
            CreateMap<Turma_Aluno, Turma_AlunoDTO>().ReverseMap();
            CreateMap<Turma_Aluno, Turma_AlunoCreateDTO>().ReverseMap();
        }
    }
}
