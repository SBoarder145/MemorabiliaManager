using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class ItemCategory
	{
		public int Id { get; set; }
		[Required]
		[StringLength(20)]
		public string Name { get; set; } = string.Empty;
		public List<Item> Items { get; set; } = new List<Item>();
	}
}
