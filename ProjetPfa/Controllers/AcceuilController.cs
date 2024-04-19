using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class AcceuilController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }

    }
}
