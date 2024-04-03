using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
