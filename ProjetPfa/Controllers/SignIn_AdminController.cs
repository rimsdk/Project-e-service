using Microsoft.AspNetCore.Mvc;
using ProjetPfa.Models;
using ProjetPfa.ModelView;

namespace ProjetPfa.Controllers
{
    public class SignIn_AdminController : Controller
    {
        private readonly MyContext _context;
        public SignIn_AdminController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Show()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Show(AdminSignInVM A)
        {
            if (ModelState.IsValid)
            {
                // Récupérer l'utilisateur avec l'email et le mot de passe fournis
                Admin user = _context.Admins.FirstOrDefault(u => u.Email == A.Email && u.Mdp == A.Mdp);

                // Vérifier si l'utilisateur existe
                if (user != null)
                {
                    // Rediriger vers la page d'accueil par exemple
                    return RedirectToAction("Show", "AdminListe");
                }
                else
                {
                    // Si l'utilisateur n'existe pas ou les informations d'identification sont incorrectes, afficher un message d'erreur
                    ModelState.AddModelError(string.Empty, "L'email ou le mot de passe est incorrect.");
                    return View("Show");
                }
            }

            // Si le modèle n'est pas valide, retourner la vue avec les erreurs
            return View("Show", A);
        }
        public IActionResult Choix()
        {
            return View();
        }

    }
}
