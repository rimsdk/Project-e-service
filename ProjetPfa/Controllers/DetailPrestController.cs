using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetPfa.Models;
using ProjetPfa.ModelView;
using System;



namespace ProjetPfa.Controllers
{
    public class DetailPrestController : Controller
    {
        private readonly MyContext context;

        public DetailPrestController(MyContext context)
        {
            context = context;
        }
      
        [HttpPost]
        public ActionResult Create(DetailCompteVM model)
        {
            if (ModelState.IsValid)
            {
                
                var detailCompte = new DetailCompte
                {
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    OrgName = model.OrgName,
                    Languages = new List<Language>() 
                };

               
                context.DetailComptes.Add(detailCompte);
                context.SaveChanges();

               
                if (model.Languages != null && model.LanguageLevels != null && model.Languages.Count == model.LanguageLevels.Count)
                {
                    for (int i = 0; i < model.Languages.Count; i++)
                    {
                        var language = new Language
                        {
                            Name = model.Languages[i],
                            Level = model.LanguageLevels[i],
                            DetailCompteId = detailCompte.Id 
                        };
                        context.Languages.Add(language);
                    }
                    context.SaveChanges();
                }

               
                return RedirectToAction("SuccessPage");
            }

          
            return View(model);
        }
        public ActionResult SuccessPage()
        {
          
            return View();
        }
        public ActionResult social()
        {

            return View();
        }
        public ActionResult verify()
        {

            return View();
        }
    }
}


