
namespace SolidTech.Presentation.Controllers
{
    public class HomeController : BaseController
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

            List<TeamMemberDto> teamMembers = _teamMemberService.TeamMembers();
            List<CustomerCommentDto> customerComments = _customerCommentService.CustomerComments();

            HomeIndexModel indexModel = new();//   HomeIndexModel indexModel = new HomeIndexModel()
            indexModel.Create(solutions, projectCategories, projects, teamMembers, customerComments);
            ViewBag.GetLastProjects = _projectService.GetLastProjects();
            return View(indexModel);
        }

    }
}


/*
   public IActionResult Index()
        {
            List<SolutionDto> solutions = _solutionService.GetServices();
            List<ProjectCategoryDto> projectCategories = _projectCategoryService.ProjectCategories();
            List<ProjectDto> projects = _projectService.Projects();
            List<TeamMemberDto> teamMembers = _teamMemberService.TeamMemberBusinesss();
            List<CustomerCommentDto> customerComments = _customerCommentService.CustomerComments();
            ViewBag.Solutions = solutions;
            ViewBag.Projects = projects;   //@ViewBag.Projects
            ViewData["Solutions"] = solutions;  //@ViewData["Solutions"]
            ViewData["Projects"] = projects;
            TempData["Solutions"] = solutions; //@TempData["Solutions"]
            TempData["Projects"] = projects;
            var tuple = Tuple.Create(solutions, projects);
            View(tuple); //@model Tuple<List<SolutionDto>,List<ProjectDto>> //Model.
            return View(tuple);
        }
 */