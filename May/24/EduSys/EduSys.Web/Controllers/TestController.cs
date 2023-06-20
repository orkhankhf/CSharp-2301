using Microsoft.AspNetCore.Mvc;

namespace EduSys.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
