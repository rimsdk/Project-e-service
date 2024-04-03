namespace ProjetPfa.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public float Note { get; set; }

        public string  Commentaire { get; set; }
        public string Description { get; set; }

        IList <Admin> Admins { get; set; }

        IList <FeedBack> Feedbacks { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }


    }
}
