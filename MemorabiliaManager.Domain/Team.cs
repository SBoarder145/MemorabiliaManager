namespace MemorabiliaManager.Domain
{
    public class Team
    {
        public int Id { get; set; }
        public League League { get; set; } = new League();
        public string Name { get; set; } = string.Empty;
        public List<Player> Players { get; set; } = new List<Player>();
        public int LeagueId { get; set; } = 0;
    }
}
