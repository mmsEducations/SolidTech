using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Businesses
{
    public class ProjectBusiness : IProjectBusiness
    {
        private readonly SolidTechContext _context;
        public ProjectBusiness(SolidTechContext context)
        {
            _context = context;
        }

        public List<Project> Projects()
        {
            return _context.Projects.ToList();
        }
    }
}
