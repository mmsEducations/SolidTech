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
