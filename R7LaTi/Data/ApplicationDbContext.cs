using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using R7LaTi.Models;

namespace R7LaTi.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Organizer>()
            .HasMany(t => t.Trips)
            .WithOne()
            .HasForeignKey(f => f.OrganizerId);

            builder.Entity<Country>()
                .HasMany(a => a.Addresses)
                .WithOne()
                .HasForeignKey(f => f.CountryId);



            #region ManyToMany
            builder.Entity<UserTrips>().HasKey(sec => new {sec.UserId , sec.TripId});

            builder.Entity<UserTrips>()
            .HasOne(c => c.Users)
            .WithMany(t => t.UsersTrips)
            .HasForeignKey(f => f.UserId);

            builder.Entity<UserTrips>()
            .HasOne(c => c.Trips)
            .WithMany(t => t.UsersTrips)
            .HasForeignKey(f => f.TripId);


            builder.Entity<UserAddress>().HasKey(sec => new {sec.UserId , sec.AdderssId});
            builder.Entity<UserAddress>().HasOne(u => u.Uesr).WithMany().HasForeignKey(f => f.UserId);
            builder.Entity<UserAddress>().HasOne(u => u.Adderss).WithMany().HasForeignKey(f => f.AdderssId);
            
            #endregion 
            builder.Entity<ApplicationUsers>()
            .Property(p => p.FullName).HasComputedColumnSql("[FirstName] + ' ' + [LastName]");


            builder.Entity<ApplicationUsers>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTodens");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            
        }

        public DbSet<Trip> Trips {get; set;}
        public DbSet<Organizer> Organizers {get; set;}
        public DbSet<UserTrips> UsersTrips {get; set;}
        public DbSet<Photo> Photos {get; set;}
        public DbSet<UserAddress> UserAddresses {get; set;}
    }
}