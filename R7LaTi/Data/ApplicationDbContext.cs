using Microsoft.EntityFrameworkCore;
using R7LaTi.Models;

namespace R7LaTi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Organizer>()
            .HasMany(t => t.Trips)
            .WithOne(o => o.Organizer)
            .HasForeignKey(f => f.OrganizerId);


            builder.Entity<CustomersTrips>().HasKey(sec => new {sec.CustomerId , sec.TripId});

            builder.Entity<CustomersTrips>()
            .HasOne(c => c.Customers)
            .WithMany(t => t.CustomersTrips)
            .HasForeignKey(f => f.CustomerId);

            builder.Entity<CustomersTrips>()
            .HasOne(c => c.Trips)
            .WithMany(t => t.CustomersTrips)
            .HasForeignKey(f => f.TripId);


            builder.Entity<Customer>()
            .Property(p => p.FullName).HasComputedColumnSql("[FirstName] + ' ' + [LastName]");

            builder.Entity<Organizer>()
            .Property(p => p.FullName).HasComputedColumnSql("[FirstName] + ' ' + [LastName]");
            
        }
    }
}