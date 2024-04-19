using System.ComponentModel.DataAnnotations;

namespace ProjetPfa.ModelView
{
    public class PrestataireSignInVM
    {
        [Required(ErrorMessage = "Le champ E-mail est requis")]
        [EmailAddress(ErrorMessage = "Veuillez saisir une adresse e-mail valide")]
        [EmailPattern(ErrorMessage = "L'adresse e-mail doit contenir le symbole '@'")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le champ Mot de passe est requis")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Le mot de passe est Incorrecte ")]
        public string Mdp { get; set; }
    }
}
