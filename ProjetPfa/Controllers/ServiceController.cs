using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetPfa.Models;
using ProjetPfa.ModelView;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ProjetPfa.Controllers
{
    public class ServiceController : Controller
    {
        private readonly MyContext _context;



        public ServiceController(MyContext context)
        {
            _context = context;

        }
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Categories.ToList();

            var viewModel = new ServiceAddVM(); // Initialisez le modèle ici

            return View(viewModel);
        }



        [HttpPost]
        public async Task<IActionResult> Add(ServiceAddVM viewModel, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                int? userId = HttpContext.Session.GetInt32("PrestataireId");

                var service = new Service
                {
                    Libelle = viewModel.Libelle,
                    Description = viewModel.Description,
                    CategorieId = viewModel.CategorieId,
                    PrestataireId = userId.Value,

                    Image = await SaveImageFile(imageFile)
                };

                _context.Services.Add(service);
                await _context.SaveChangesAsync();

                return RedirectToAction("Show", "About"); // Assurez-vous que c'est la redirection voulue
            }

            // Rechargez la liste des catégories
            ViewBag.Categories = _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Libelle })
                .ToList();

            return RedirectToAction("Show", "Acceuil");
        }

        private async Task<string> SaveImageFile(IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                Directory.CreateDirectory(uploadPath); // CreateDirectory vérifie déjà si le répertoire existe

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                return "/images/" + fileName;
            }

            return null;
        }

    }
}
