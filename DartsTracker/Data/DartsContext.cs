using DartsTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DartsTracker.Data
{
    public class DartsContext : DbContext
    {
        public DartsContext(DbContextOptions<DartsContext> options) : base(options) { }

        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<Match> Match { get; set; }
    }
}
