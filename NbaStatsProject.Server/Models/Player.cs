namespace NbaStatsProject.Server.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double PointsPerGame { get; set; }
        public double ReboundsPerGame { get; set; }
        public double AssistsPerGame { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
