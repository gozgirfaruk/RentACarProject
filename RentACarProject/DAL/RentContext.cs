using Microsoft.EntityFrameworkCore;

namespace RentACarProject.DAL
{
    public class RentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog = RentACarDB; Integrated Security=true");
        }

        public DbSet<Car> Cars { get; set; }
    }
}
