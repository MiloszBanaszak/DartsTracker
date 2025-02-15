using DartsTracker.Data;
using DartsTracker.Models;
using Microsoft.EntityFrameworkCore;
namespace DartsTracker.Services
{
    public class TournamentService
    {
        private readonly DartsContext _context;

        public TournamentService(DartsContext context)
        {
            _context = context;

        }

        public async Task<List<Tournament>> GetTournamentsAsync()
        {
            return await _context.Tournaments.Include(t => t.Matches).ToListAsync();
        }

        public async Task AddTournamentAsync(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
            await _context.SaveChangesAsync();
        }
    }
}
