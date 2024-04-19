using Microsoft.AspNetCore.Mvc;

namespace ProjetPfa.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
