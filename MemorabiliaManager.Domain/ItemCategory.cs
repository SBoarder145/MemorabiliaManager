using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class ItemCategory : IEquatable<ItemCategory>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(20)]
		public string Name { get; set; } = string.Empty;
		public List<Item> Items { get; set; } = new List<Item>();

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as ItemCategory);
		}

		public bool Equals(ItemCategory? other)
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
