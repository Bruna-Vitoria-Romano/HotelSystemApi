using HotelSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.Infra.Data.Context
{
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {

        }

        public DbSet<HotelGuest> Guests { get; set; }
        public DbSet<HotelReception> Reception { get; set; }
        public DbSet<Rooms> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextApplication).Assembly);
        }
    }
}
