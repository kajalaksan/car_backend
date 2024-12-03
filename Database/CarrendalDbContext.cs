using CarEndals.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarEndals.Datbase
{
    public class CarrendalDbContext : DbContext
    {
        public CarrendalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }
    }
}
