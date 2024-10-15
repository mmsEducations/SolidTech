namespace SolidTech.Business.Services
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        private readonly SolidTechContext _context;
        private readonly IMapper _mapper;

        public ProjectCategoryService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProjectCategoryDto> ProjectCategories()
        {
            var projectCaegories = _context.ProjectCategories.ToList();
            return _mapper.Map<List<ProjectCategoryDto>>(projectCaegories);
        }

    }
}
