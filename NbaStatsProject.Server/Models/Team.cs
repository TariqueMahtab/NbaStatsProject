using System.Text.Json.Serialization;
using NbaStatsProject.Server.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Conference { get; set; }

    [JsonIgnore]  // This is the key change
    public List<Player> Players { get; set; }
}
