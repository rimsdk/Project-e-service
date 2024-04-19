using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
