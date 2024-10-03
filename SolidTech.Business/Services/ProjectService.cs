using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly SolidTechContext _context;
        public ProjectService(SolidTechContext context)
        {
            _context = context;
        }

        public List<Project> Projects()
        {
            return _context.Projects.ToList();
        }
    }
}
