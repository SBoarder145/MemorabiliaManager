using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Entertainment
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;
		[Required]
		[StringLength(100)]
		public string Category { get; set; } = string.Empty;
		public bool IsSportTeam { get; set; } = false;
		public List<Item> Items { get; set; } = new List<Item>();
		public List<Subject> Subjects { get; set; } = new List<Subject>();
		public List<Signature>? Signatures { get; set; } = new List<Signature>();
	}
}
