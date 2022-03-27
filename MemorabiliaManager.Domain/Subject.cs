namespace MemorabiliaManager.Domain
{
	public class Subject
	{
		public int Id { get; set; }
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<ItemSubject> Items { get; set; } = new List<ItemSubject>();
		public string Name { get; set; } = string.Empty;
		public int EntertainmentId { get; set; } = 0;
	}
}
