using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class ListeController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
