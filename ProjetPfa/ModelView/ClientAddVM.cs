using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetPfa.ModelView
{
    public class ClientAddVM
    {
       // [Required(ErrorMessage = "Le champ Nom est requis")]
        public string Nom { get; set; }

        //[Required(ErrorMessage = "Le champ Prénom est requis")]
        public string Prenom { get; set; }

        //[Required(ErrorMessage = "Le champ E-mail est requis")]
        //[EmailAddress(ErrorMessage = "Veuillez saisir une adresse e-mail valide")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Le champ Mot de passe est requis")]
        public string Mdp { get; set; }

        //[Compare("Mdp", ErrorMessage = "Les mots de passe ne correspondent pas")]
        public string cMdp { get; set; }

        //[Required(ErrorMessage = "Le champ Date de naissance est requis")]
        //[DataType(DataType.Date)]
        public DateTime Date_de_naissance { get; set; }

       // [Required(ErrorMessage = "Le champ Genre est requis")]
        public string Genre { get; set; }

        //[Required(ErrorMessage = "Le champ Téléphone est requis")]
        //[Phone(ErrorMessage = "Le numéro de téléphone doit être valide")]
        public string Telephone { get; set; }

        //[Required(ErrorMessage = "Le champ Adresse est requis")]
        public string Adresse { get; set; }
    }
}
