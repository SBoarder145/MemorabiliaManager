namespace MemorabiliaManager.Domain
{
	public class Image
	{
		public int Id { get; set; }
		public string FileName { get; set; } = string.Empty;
		public string ByteArray { get; set; } = string.Empty;
		public List<ItemImage> Items { get; set; } = new List<ItemImage>();
	}
}
