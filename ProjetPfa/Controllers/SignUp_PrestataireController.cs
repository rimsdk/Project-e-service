using Microsoft.AspNetCore.Mvc;
using ProjetPfa.Models; // Assurez-vous d'ajouter l'espace de noms de vos modèles
using ProjetPfa.ModelView;
using System;


namespace ProjetPfa.Controllers
{
    public class SignUp_PrestataireController : Controller
    {
        private readonly MyContext db;

        public SignUp_PrestataireController(MyContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult SignUp_Prestataire()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp_Prestataire(PrestataireAddVM model)
        {
            if (ModelState.IsValid)
            {

                    var prestataire = new Prestataire
                    {
                        Nom = model.Nom,
                        Prenom = model.Prenom,
                        Email = model.Email,
                        Mdp = model.Mdp, // Pensez à la sécurisation du mot de passe
                        Date_de_naissance = model.Date_de_naissance.ToString("yyyy-MM-dd"), // Conversion en string; envisagez de changer le type
                        Telephone = model.Téléphone,
                        Adresse = model.Adresse,
                        Genre = model.Genre
                        // Les champs Image et Certificat sont omis ici
                    };

                    db.Prestataires.Add(prestataire);
                    db.SaveChanges();
                    return RedirectToAction("EditProfil"); // Ou toute autre vue que vous souhaitez afficher après l'enregistrement réussi

            }

            // Si le modèle n'est pas valide, ou si une exception est survenue, on affiche à nouveau le formulaire
            return View(model);
        }
        public IActionResult EditProfil()
        {
            // Logique de modification du profil
            return View();
        }
    }
}
