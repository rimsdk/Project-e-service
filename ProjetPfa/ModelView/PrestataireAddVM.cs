using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetPfa.ModelView
{
    public class PrestataireAddVM
    {
        [Required(ErrorMessage = "Le champ Nom est requis")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le champ Prénom est requis")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le champ E-mail est requis")]
        [EmailAddress(ErrorMessage = "Veuillez saisir une adresse e-mail valide")]
        [EmailPattern(ErrorMessage = "L'adresse e-mail doit contenir le symbole '@'")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le champ Mot de passe est requis")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Le mot de passe doit être long de 8 caractères minimum et contenir au moins un chiffre")]
        public string Mdp { get; set; }

        [Compare("Mdp", ErrorMessage = "Les mots de passe ne correspondent pas")]
        public string cMdp { get; set; }

        [Required(ErrorMessage = "Le champ Date de naissance est requis")]
        [DataType(DataType.Date)]
        [AgeValidation(ErrorMessage = "Vous devez être majeur")]
        public DateTime Date_de_naissance { get; set; }

        [Required(ErrorMessage = "Le champ Téléphone est requis")]
        [RegularExpression(@"^(\+[0-9]{1,3})?[0-9]{10}$", ErrorMessage = "Le numéro de téléphone doit être valide")]
        [Phone(ErrorMessage = "Le numéro de téléphone doit être valide")]
        public string Téléphone { get; set; }

        [Required(ErrorMessage = "Le champ Adresse est requis")]
        public string Adresse { get; set; }



      [Required(ErrorMessage = "Le champ Genre est requis")]
        public string Genre { get; set; }
    }

    public class AgeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime date)
            {
                return date <= DateTime.Now.AddYears(-18); // Vérifie si l'utilisateur a 18 ans ou plus
            }
            return false;
        }
    }

    public class EmailPatternAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string email)
            {
                return email.Contains("@"); // Vérifie si l'e-mail contient le symbole '@'
            }
            return false;
        }
    }
}
