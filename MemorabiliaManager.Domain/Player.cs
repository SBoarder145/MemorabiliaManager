namespace MemorabiliaManager.Domain
{
    public class Player
    {
        public int Id { get; set; }
        public Team Team { get; set; } = new Team();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Number { get; set; } = 0;
        public int TeamId { get; set; } = 0;
    }
}
