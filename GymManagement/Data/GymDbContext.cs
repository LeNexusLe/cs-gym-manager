using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GymManagement.Data
{
    public class GymDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jan.kowalski@example.com", Phone = "123456789" },
                new Member { Id = 2, FirstName = "Anna", LastName = "Nowak", Email = "anna.nowak@example.com", Phone = "987654321" }
            );

            modelBuilder.Entity<Membership>().HasData(
                new Membership { Id = 1, MemberId = 1, StartDate = new DateTime(2025, 6, 5).ToUniversalTime(), EndDate = new DateTime(2025, 7, 5).ToUniversalTime() },
                new Membership { Id = 2, MemberId = 2, StartDate = new DateTime(2025, 5, 5).ToUniversalTime(), EndDate = new DateTime(2025, 6, 5).ToUniversalTime() }
            );

            modelBuilder.Entity<Attendance>().HasData(
                new Attendance { Id = 1, MemberId = 1, CheckInDate = new DateTime(2025, 6, 5).ToUniversalTime() },
                new Attendance { Id = 2, MemberId = 2, CheckInDate = new DateTime(2025, 5, 4).ToUniversalTime() },
                new Attendance { Id = 3, MemberId = 2, CheckInDate = new DateTime(2025, 6, 15).ToUniversalTime() },
                new Attendance { Id = 4, MemberId = 1, CheckInDate = new DateTime(2025, 5, 25).ToUniversalTime() }
            );

            modelBuilder.Entity<WorkoutPlan>().HasData(
                new WorkoutPlan { Id = 1, MemberId = 1, Exercise = "Przysiady", Sets = 3, Reps = 12, DayOfWeek = "Poniedzia³ek" },
                new WorkoutPlan { Id = 2, MemberId = 2, Exercise = "Martwy ci¹g", Sets = 4, Reps = 8, DayOfWeek = "Œroda" }
            );
        }

    }
}