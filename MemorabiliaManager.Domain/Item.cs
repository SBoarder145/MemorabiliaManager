namespace MemorabiliaManager.Domain
{
	public class Item
	{
		public int Id { get; set; }
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<ItemSubject>? Subjects { get; set; } = null;
		public Signature? Signature { get; set; } = null;
		public ItemCategory ItemCategory { get; set; } = new ItemCategory();
		public string Name { get; set; } = string.Empty;
		public string? ItemCollectionNumber { get; set; } = null;
		public List<ItemImage>? Images { get; set; } = null;
		public int EntertainmentId { get; set; } = 0;
		public int ItemCategoryId { get; set; } = 0;
	}
}
