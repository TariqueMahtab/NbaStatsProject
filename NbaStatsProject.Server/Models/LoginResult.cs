namespace NbaStatsProject.Server.Models
{
    public class LoginResult
    {
        public bool Success { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
