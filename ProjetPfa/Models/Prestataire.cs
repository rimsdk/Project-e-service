namespace ProjetPfa.Models
{
    public class Prestataire
    {
        public int Id { get; set; }
        public  string  Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }

        public string Date_de_naissance { get; set; }

        public string Genre { get; set; }
        public  string  Telephone { get; set; }
        public string Adresse { get; set; }
        public  string? Image { get; set; }

        public string? Certificat { get; set; }

        IList<Admin> Admins { get; set; }
        IList<Service> Services { get; set; }

    }

}
