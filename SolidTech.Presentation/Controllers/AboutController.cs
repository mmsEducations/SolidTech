

namespace SolidTech.Presentation.Controllers
{
    public class AboutController : BaseController
    {
        private readonly ITeamMemberService _teamMemberService;

        public AboutController(ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
        }

        public IActionResult Index()
        {
            List<TeamMemberDto> teamMembers = _teamMemberService.TeamMembers();
            ViewBag.TeamMembers = teamMembers;
            return View();
        }
    }
}
