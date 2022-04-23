using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class AuthenticationService : IEquatable<AuthenticationService>
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		[StringLength(100)]
		public string Website { get; set; } = string.Empty;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as AuthenticationService);
		}

		public bool Equals(AuthenticationService? other)
		{
			return other != null && ReferenceEquals(this, other);
		}

		public override int GetHashCode()
		{
			return Id;
		}
		#endregion
	}
}
