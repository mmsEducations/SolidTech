using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Services
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        private readonly SolidTechContext _context;
        public ProjectCategoryService(SolidTechContext context)
        {
            _context = context;
        }

        public List<ProjectCategory> ProjectCategories()
        {
            return _context.ProjectCategories.ToList();
        }

    }
}
