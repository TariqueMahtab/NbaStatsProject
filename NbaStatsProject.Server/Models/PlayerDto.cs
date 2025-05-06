namespace NbaStatsProject.Server.Models
{
    public class PlayerDto
    {
        public string PlayerName { get; set; } = "";
        public string Team { get; set; } = "";
        public string Position { get; set; } = "";
        public int GamesPlayed { get; set; }
        public float MinutesPlayed { get; set; }
        public float Points { get; set; }
        public float Assists { get; set; }
        public float Rebounds { get; set; }
    }
}
