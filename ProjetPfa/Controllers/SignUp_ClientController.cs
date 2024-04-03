using Microsoft.AspNetCore.Mvc;
using ProjetPfa.Models;
using ProjetPfa.ModelView;
using System;

namespace ProjetPfa.Controllers
{
    public class SignUp_ClientController : Controller
    {
        private readonly MyContext db;

        public SignUp_ClientController(MyContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult SignUp_Client()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp_Client(ClientAddVM model)
        {
            if (ModelState.IsValid)
            {

                    var client = new Client
                    {
                        Nom = model.Nom,
                        Prenom = model.Prenom,
                        Email = model.Email,
                        Mdp = model.Mdp,
                        Date_de_naissance = model.Date_de_naissance.ToString("yyyy-MM-dd"),
                        Genre = model.Genre,
                        Telephone = model.Telephone,
                        Adresse = model.Adresse
                    };

                    db.Clients.Add(client);
                    db.SaveChanges();

                    // Rediriger vers une autre action après l'enregistrement réussi si nécessaire
                    return RedirectToAction("Show", "Acceuil");

            }

            // Si le modèle n'est pas valide ou s'il y a eu une exception, afficher à nouveau le formulaire avec les erreurs
            return View(model);
        }
    }
}
