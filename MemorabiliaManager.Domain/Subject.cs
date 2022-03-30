using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Subject
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; } = string.Empty;
		[Required]
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<ItemSubject> Items { get; set; } = new List<ItemSubject>();
		public int EntertainmentId { get; set; } = 0;
	}
}
