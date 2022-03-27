namespace MemorabiliaManager.Domain
{
	public class ItemImage
	{
		public int Id { get; set; }
		public Item Item { get; set; } = new Item();
		public Image Image { get; set; } = new Image();
		public int ItemId { get; set; } = 0;
		public int ImageId { get; set; } = 0;
	}
}
