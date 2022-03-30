using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Signature
	{
		public int Id { get; set; }
		[Required]
		[StringLength(15)]
		public string FirstName { get; set; } = string.Empty;
		[Required]
		[StringLength(20)]
		public string LastName { get; set; } = string.Empty;
		[Range(1, 99)]
		public short? JerseyNumber { get; set; } = null;
		[StringLength(15)]
		public string? AuthenticationNumber { get; set; } = null;
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<ItemSignature> Items { get; set; } = new List<ItemSignature>();
		public int EntertainmentId { get; set; } = 0;
	}
}
