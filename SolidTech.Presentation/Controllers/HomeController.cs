using Microsoft.AspNetCore.Mvc;
using SolidTech.Business.Interfaces;
using SolidTech.Data.Entities;

namespace SolidTech.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceBusiness _serviceBusiness;
        private readonly IProjectCategoryBusiness _projectCategoryBusiness;
        private readonly IProjectBusiness _projectBusiness;
        private readonly ITeamMemberBusiness _teamMemberBusiness;
        public HomeController(IServiceBusiness serviceBusiness,
                              IProjectCategoryBusiness projectCategoryBusiness,
                              IProjectBusiness projectBusiness,
                              ITeamMemberBusiness teamMemberBusiness)
        {
            _serviceBusiness = serviceBusiness;
            _projectCategoryBusiness = projectCategoryBusiness;
            _projectBusiness = projectBusiness;
            _teamMemberBusiness = teamMemberBusiness;
        }
        public IActionResult Index()
        {
            List<Service> services = _serviceBusiness.GetServices();
            List<ProjectCategory> projectCategories = _projectCategoryBusiness.ProjectCategories();
            List<Project> projects = _projectBusiness.Projects();
            List<TeamMember> teamMembers = _teamMemberBusiness.TeamMemberBusinesss();
            return View();
        }

    }
}
