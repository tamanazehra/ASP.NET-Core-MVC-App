using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitLog> HabitLogs { get; set; }
    }
}


