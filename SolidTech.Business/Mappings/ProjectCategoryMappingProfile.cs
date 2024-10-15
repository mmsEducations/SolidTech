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
