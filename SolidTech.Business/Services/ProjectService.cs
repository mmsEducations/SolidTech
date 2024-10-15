namespace SolidTech.Business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly SolidTechContext _context;
        private readonly IMapper _mapper;

        public ProjectService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProjectDto> Projects()
        {
            return _mapper.Map<List<ProjectDto>>(_context.Projects.ToList());
        }

        public List<ProjectDto> GetLastProjects()
        {
            return _mapper.Map<List<ProjectDto>>(_context.Projects.OrderByDescending(x => x.CreaDate).Take(6));
        }
    }
}
