namespace ProjetPfa.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Prestataire Prestataire { get; set; }
        public int PrestataireId { get; set; }
        public Categorie Categorie { get; set; }    
        public int CategorieId { get;  set; }
        IList<FeedBack> FeedBacks { get; set; }
        IList<Admin> admins { get; set; }
        IList <Reservation> reservations { get; set; }


        
    }
}
