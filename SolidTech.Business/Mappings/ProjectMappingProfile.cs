using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Mappings
{
    public class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {
            CreateMap<Project, ProjectDto>()
                     .ReverseMap();
        }
    }
}
