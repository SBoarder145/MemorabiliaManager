using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Authentication
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string AuthenticationService { get; set; } = string.Empty;
		[Required]
		[StringLength(20)]
		public string AuthenticationCode { get; set; } = string.Empty;
		[Required]
		public Item Item { get; set; } = new Item();
		[Required]
		public Signature Signature { get; set; } = new Signature();
		public int ItemId { get; set; } = 0;
		public int SignatureId { get; set; } = 0;
	}
}
