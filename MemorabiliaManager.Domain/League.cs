namespace MemorabiliaManager.Domain
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}