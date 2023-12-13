using Microsoft.AspNetCore.Mvc;

namespace ProductivePomodoro.Controllers
{
    public class PomodoroController : Controller
    {
        public IActionResult Timer()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }
    }
}
