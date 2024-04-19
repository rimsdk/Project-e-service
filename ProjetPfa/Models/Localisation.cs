namespace ProjetPfa.Models
{
    public class Localisation
    {
        
        public int Id { get; set; }
        public string Libelle { get; set; }
        IList <Reservation> Reservations { get; set; }

    }
}
