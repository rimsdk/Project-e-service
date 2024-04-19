using Microsoft.AspNetCore.Mvc;
using ProjetPfa.Models;

namespace ProjetPfa.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly MyContext db;

        public CategoriesController(MyContext context)
        {
            db = context;
        }
        public IActionResult Show()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }
    }
}
