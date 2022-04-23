using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Signature : IEquatable<Signature>
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
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<Item> Items { get; set; } = new List<Item>();
		public int EntertainmentId { get; set; } = 0;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as Signature);
		}

		public bool Equals(Signature? other)
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
