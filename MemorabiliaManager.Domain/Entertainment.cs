namespace MemorabiliaManager.Domain
{
	public class Entertainment
	{
		public int Id { get; set; }
		public EntertainmentCategory EntertainmentCategory { get; set; } = new EntertainmentCategory();
		public List<Item> Items { get; set; } = new List<Item>();
		public List<Subject> Subjects { get; set; } = new List<Subject>();
		public List<Signature>? Signatures { get; set; } = new List<Signature>();
		public string Name { get; set; } = string.Empty;
		public int EntertainmentCategoryId { get; set; } = 0;
	}
}
