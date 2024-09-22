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

        [HttpPost]
        public IActionResult Index(calModels model)
        {
            if (ModelState.IsValid)
            {
                switch (model)
                {
                    case "Add":
                        model.FinalValue = model.FirstValue + model.SecondValue;
                        break;
                    case "Subtract":
                        model.FinalValue = model.FirstValue - model.SecondValue;
                        break;
                    case "Multiply":
                        model.FinalValue = model.FirstValue * model.SecondValue;
                        break;
                    case "Divide":
                        model.FinalValue = model.SecondValue != 0 ? model.FirstValue / model.SecondValue : (int?)null;
                        break;
                    default:
                        ModelState.AddModelError("", "Invalid operation selected.");
                        break;
                }
            }

            return View(model);
        }
    }
}
