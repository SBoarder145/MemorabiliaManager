using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class EntertainmentCategory : IEquatable<EntertainmentCategory>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(10)]
		public string Name { get; set; } = string.Empty;
		public bool IsSport { get; set; } = false;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as EntertainmentCategory);
		}

		public bool Equals(EntertainmentCategory? other)
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
