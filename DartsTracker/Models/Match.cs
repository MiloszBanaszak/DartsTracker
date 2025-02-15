namespace DartsTracker.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; } = null!;
        public bool IsWin { get; set; }
        public int DartsThrown { get; set; }
        public double MatchAverage { get; set; }
        public double FirstNineDartAverage { get; set; }
    }
}
