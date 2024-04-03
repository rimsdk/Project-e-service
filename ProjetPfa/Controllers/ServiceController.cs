using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetPfa.Models;
using ProjetPfa.ModelView;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceAddVM viewModel, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                var service = new Service
                {
                    Libelle = viewModel.Libelle,
                    Description = viewModel.Description,
                    CategorieId = viewModel.CategorieId
                };

                if (imageFile != null && imageFile.Length > 0)
                {
                    var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    var filePath = Path.Combine(uploadPath, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    service.Image = "/images/" + fileName;
                }

                _context.Services.Add(service);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            // Si le modèle n'est pas valide, remplissez à nouveau la liste déroulante des catégories
            viewModel.Categories = _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Libelle })
                .ToList();

            return View("Create", viewModel);
        }
    }
}
