using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Authentication : IEquatable<Authentication>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public AuthenticationService? AuthenticationService { get; set; } = null;
		[Required]
		[StringLength(20)]
		public string AuthenticationCode { get; set; } = string.Empty;
		[Required]
		public Item Item { get; set; } = new Item();
		[Required]
		public Signature Signature { get; set; } = new Signature();
		public int? AuthenticationServiceId = null;
		public int ItemId { get; set; } = 0;
		public int SignatureId { get; set; } = 0;

		#region IEquatable Methods
		public bool Equals(Authentication? other)
		{
			return other != null && ReferenceEquals(this, other);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Authentication);
		}

		public override int GetHashCode()
		{
			return Id;
		}
		#endregion
	}
}
