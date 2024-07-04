using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CCategory> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CCategory>().HasData(
                new CCategory { Id = 1, Name = "Action", DisplayOrder = 1 },
                new CCategory { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new CCategory { Id = 3, Name = "History", DisplayOrder = 3 });
        }
    }
}
