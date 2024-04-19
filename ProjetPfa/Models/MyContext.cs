using Microsoft.EntityFrameworkCore;

namespace ProjetPfa.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Admin>  Admins { get; set; }
        public DbSet<Prestataire> Prestataires  { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet <FeedBack> FeedBacks { get; set; }
        public DbSet <Categorie> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet <Localisation> Localisation { get; set; }

        public MyContext(DbContextOptions options) : base(options)
        {
        }
    }
}
