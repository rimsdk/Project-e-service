namespace ProjetPfa.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public string  Email { get; set; }
        public string Mdp { get; set; }
        public string Telephone { get; set; }
        public string role { get; set;}
        IList<Client> Clients { get; set; }
        IList<Prestataire> Prestataires { get; set; }
        IList<FeedBack> FeedBacks { get; set; }
        IList <Service> Services { get; set; }

    }
}
