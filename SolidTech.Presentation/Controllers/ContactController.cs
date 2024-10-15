
namespace SolidTech.Presentation.Controllers
{
    public class ContactController : BaseController
    {
        private readonly IMessageService _messageService;
        private readonly IProjectService _projectService;

        public ContactController(IMessageService messageService, IProjectService projectService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            List<MessageDto> messages = _messageService.Messages();
            return View();
        }
    }
}
