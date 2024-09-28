using Microsoft.AspNetCore.Mvc;
using SolidTech.Business.Businesses;
using SolidTech.Data.Entities;

namespace SolidTech.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceBusiness _serviceBusiness;

        private readonly ProjectCategoryBusiness _projectCategoryBusiness;
        public HomeController(ServiceBusiness serviceBusiness, ProjectCategoryBusiness projectCategoryBusiness)
        {
            _serviceBusiness = serviceBusiness;
            _projectCategoryBusiness = projectCategoryBusiness;

        }
        public IActionResult Index()
        {
            List<Service> services = _serviceBusiness.GetServices();
            return View();
        }
    }
}
