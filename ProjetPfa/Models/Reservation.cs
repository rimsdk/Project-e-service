namespace ProjetPfa.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date_res { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Localisation Localisation { get; set; }
        public int LocalisationId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }



    }
}
