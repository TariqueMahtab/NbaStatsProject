namespace NbaStatsProject.Server.Models
{
    public class Player
    {
        public double Id { get; set; }                       // float in SQL — treat as double

        public string PlayerName { get; set; } = "";         // nvarchar
        public string Team { get; set; } = "";               // nvarchar
        public string Position { get; set; } = "";           // nvarchar

        public double? GamesPlayed { get; set; }             // float?
        public double? MinutesPlayed { get; set; }           // float?
        public double? Points { get; set; }                  // float?
        public double? Assists { get; set; }                 // float?
        public double? Rebounds { get; set; }                // float?
    }
}
