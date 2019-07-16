using Microsoft.AspNetCore.Mvc;

namespace timeDisplay
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}