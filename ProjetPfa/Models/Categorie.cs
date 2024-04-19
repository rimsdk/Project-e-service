namespace ProjetPfa.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        IList<Service> services { get; set; }

    }
}
