using DartsTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DartsTracker.Data
{
    public class DartsContext : DbContext
    {
        public DartsContext(DbContextOptions<DartsContext> options) : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
