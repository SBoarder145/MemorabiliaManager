using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Item
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<Subject>? Subjects { get; set; } = null;
		public List<Signature>? Signatures { get; set; } = null;
		public ItemCategory ItemCategory { get; set; } = new ItemCategory();
		public string? ItemCollectionNumber { get; set; } = null;
		public List<Image>? Images { get; set; } = null;
		public int EntertainmentId { get; set; } = 0;
		public int ItemCategoryId { get; set; } = 0;
		public string Notes { get; set; } = string.Empty;
	}
}
