using Microsoft.AspNetCore.Mvc;

namespace myMVCUnitProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
