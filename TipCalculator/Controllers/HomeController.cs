using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fourty = 0;
            ViewBag.Fifty = 0;
            ViewBag.Sixty = 0;
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fourty = calc.CalculateTip(.40);
                ViewBag.Fifty = calc.CalculateTip(.50);
                ViewBag.Sixty = calc.CalculateTip(.60);
                ViewBag.Fifteen = calc.CalculateTip(0.15);
                ViewBag.Twenty = calc.CalculateTip(0.20);
                ViewBag.TwentyFive = calc.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fourty = 0;
                ViewBag.Fifty = 0;
                ViewBag.Sixty = 0;
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(calc);
        }
    }
}
