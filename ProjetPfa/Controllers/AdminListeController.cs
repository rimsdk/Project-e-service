using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class AdminListeController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
