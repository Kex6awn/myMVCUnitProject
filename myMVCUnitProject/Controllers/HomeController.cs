using Microsoft.AspNetCore.Mvc;
using myMVCUnitProject.Models;

namespace myMVCUnitProject.Controllers
{
    public class HomeController : Controller
    {
        // HTTP GET AND POST ACTION VERBS

        [HttpGet]
        public IActionResult Index()
        {
            return View(new calModels());
        }
    }
}
