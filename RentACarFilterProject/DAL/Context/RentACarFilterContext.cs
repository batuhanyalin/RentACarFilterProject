using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarFilterProject.DAL.Entities;

namespace RentACarFilterProject.DAL.Context
{
    public class RentACarFilterContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;initial catalog=RentACarFilter;integrated security=true");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<Schedule>()
                .HasOne(x=>x.PickUpLocation)
                .WithMany(y=>y.PickUpSchedule)
                .HasForeignKey(z=>z.PicUpLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Schedule>()
                .HasOne(x => x.DropOffLocation)
                .WithMany(y => y.DropOffSchedule)
                .HasForeignKey(z => z.DropOffLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
