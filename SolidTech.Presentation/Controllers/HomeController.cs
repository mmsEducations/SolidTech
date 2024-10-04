using Microsoft.AspNetCore.Mvc;
using SolidTech.Business.Dtos;
using SolidTech.Business.Interfaces;

namespace SolidTech.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISolutionService _solutionService;
        private readonly IProjectCategoryService _projectCategoryService;
        private readonly IProjectService _projectService;
        private readonly ITeamMemberService _teamMemberService;
        private readonly ICustomerCommentService _customerCommentService;
        public HomeController(ISolutionService solutionService,
                              IProjectCategoryService projectCategoryService,
                              IProjectService projectService,
                              ITeamMemberService teamMemberService,
                              ICustomerCommentService customerCommentService)
        {
            _solutionService = solutionService;
            _projectCategoryService = projectCategoryService;
            _projectService = projectService;
            _teamMemberService = teamMemberService;
            _customerCommentService = customerCommentService;
        }
        public IActionResult Index()
        {
            List<SolutionDto> solutions = _solutionService.GetServices();
            List<ProjectCategoryDto> projectCategories = _projectCategoryService.ProjectCategories();
            List<ProjectDto> projects = _projectService.Projects();
            List<TeamMemberDto> teamMembers = _teamMemberService.TeamMemberBusinesss();
            List<CustomerCommentDto> customerComments = _customerCommentService.CustomerComments();
            return View();

            UserEntity userEntity = new UserEntity() { Id = 1, Name = "", LastName = "", Number = 12312313 };

            UserDto userDto = new UserDto { Name = userEntity.Name, LastName = userEntity.LastName };
        }


        public class UserEntity
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

            public int Number { get; set; }
        }

        public class UserDto
        {
            public string Name { get; set; }
            public string LastName { get; set; }

        }

    }
}
