using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Entertainment : IEquatable<Entertainment>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;
		[Required]
		[StringLength(100)]
		public EntertainmentCategory EntertainmentCategory { get; set; } = new EntertainmentCategory();
		public List<Item> Items { get; set; } = new List<Item>();
		public List<Subject> Subjects { get; set; } = new List<Subject>();
		public List<Signature>? Signatures { get; set; } = new List<Signature>();
		public int EntertainmentCategoryId { get; set; } = 0;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as Entertainment);
		}

		public bool Equals(Entertainment? other)
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
