using Microsoft.AspNetCore.Mvc;
using SolidTech.Business.Dtos;
using SolidTech.Business.Interfaces;

namespace SolidTech.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectCategoryService _categoryService;
        private readonly IProjectService _projectService;

        public ProjectController(IProjectCategoryService categoryService, IProjectService projectService)
        {
            _categoryService = categoryService;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            ProjectWithCategoriesIndexModel indexModel = new();//   HomeIndexModel indexModel = new HomeIndexModel()
            indexModel.Create(_categoryService.ProjectCategories(), _projectService.Projects());
            return View(indexModel);
        }
    }
}
