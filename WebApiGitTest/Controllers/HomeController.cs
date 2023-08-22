using Microsoft.AspNetCore.Mvc;

namespace WebApiGitTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
