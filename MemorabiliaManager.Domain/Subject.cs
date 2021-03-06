using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Subject : IEquatable<Subject>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; } = string.Empty;
		[Required]
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<Item> Items { get; set; } = new List<Item>();
		public int EntertainmentId { get; set; } = 0;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as Subject);
		}

		public bool Equals(Subject? other)
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
