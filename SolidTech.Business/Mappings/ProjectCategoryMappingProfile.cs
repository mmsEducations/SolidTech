using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Mappings
{
    public class ProjectCategoryMappingProfile : Profile
    {
        public ProjectCategoryMappingProfile()
        {
            CreateMap<ProjectCategory, ProjectCategoryDto>()
                     .ReverseMap();
        }
    }
}
