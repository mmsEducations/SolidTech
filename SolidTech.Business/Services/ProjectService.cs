using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Business.Interfaces;
using SolidTech.Data;

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
    }
}
