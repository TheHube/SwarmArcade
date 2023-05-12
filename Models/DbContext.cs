using Microsoft.EntityFrameworkCore;
using ArcadeClasses;

namespace Arcade.Models
{
    public class ArcadeDbContext : DbContext
    {
        public DbSet<game> games { get; set; } = null!;
        public DbSet<player> players { get; set; } = null!;
        public DbSet<score> scores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<game>()
                .HasMany(g => g.scores)
                .WithOne(s => s.game)
                .HasForeignKey(s => s.title);

            modelBuilder.Entity<player>()
                .HasMany(p => p.scores)
                .WithOne(s => s.player)
                .HasForeignKey(s => s.username);
        }
    }
}

