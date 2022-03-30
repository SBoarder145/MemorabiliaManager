using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Image
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string FileName { get; set; } = string.Empty;
		[Required]
		public string ByteArray { get; set; } = string.Empty;
		public List<ItemImage> Items { get; set; } = new List<ItemImage>();
	}
}
