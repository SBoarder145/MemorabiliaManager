namespace MemorabiliaManager.Domain
{
    public class PlayerItem
    {
        public int Id { get; set; }
        public Player Player { get; set; } = new Player();
        public Item Item { get; set; } = new Item();
        public int PlayerId { get; set; } = 0;
        public int ItemId { get; set; } = 0;
    }
}
