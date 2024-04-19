namespace ProjetPfa.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public string Telephone { get; set; }
        public string role { get; set; }
        public DateTime DateInscription { get; set; }
        public DateTime DateDerniereConnexion { get; set; }
    }
}
  