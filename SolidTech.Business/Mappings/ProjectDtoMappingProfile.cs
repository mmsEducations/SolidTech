using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Mappings
{
    public class ProjectDtoMappingProfile : Profile
    {
        public ProjectDtoMappingProfile()
        {
            CreateMap<Project, ProjectDto>()
                     .ReverseMap();
        }
    } 
}
