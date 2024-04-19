namespace ProjetPfa.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
         
        public String  Date_de_naissance { get; set; }

        public string Genre { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set;}

        IList <FeedBack> FeedBacks { get; set; }
        IList<Admin> admins { get; set; }
        IList <Reservation> reservations { get; set; }


    }
}
