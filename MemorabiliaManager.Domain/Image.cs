using System.ComponentModel.DataAnnotations;

namespace MemorabiliaManager.Domain
{
	public class Image : IEquatable<Image>
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string FileName { get; set; } = string.Empty;
		[Required]
		public string ByteArray { get; set; } = string.Empty;
		public List<Item> Items { get; set; } = new List<Item>();
		public string Notes { get; set; } = string.Empty;

		#region IEquatable Methods
		public override bool Equals(object? obj)
		{
			return Equals(obj as Image);
		}

		public bool Equals(Image? other)
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
