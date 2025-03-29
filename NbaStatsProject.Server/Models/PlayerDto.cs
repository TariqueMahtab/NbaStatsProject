namespace NbaStatsProject.Server.Models
{
    public class PlayerDto
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public float PointsPerGame { get; set; }
        public float ReboundsPerGame { get; set; }
        public float AssistsPerGame { get; set; }
        public int TeamId { get; set; }
    }
}
