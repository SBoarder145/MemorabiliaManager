namespace MemorabiliaManager.Domain
{
	public class ItemSubject
	{
		public int Id { get; set; }
		public Item Item { get; set; } = new Item();
		public Subject Subject { get; set; } = new Subject();
		public int ItemId { get; set; } = 0;
		public int SubjectId { get; set; } = 0;
	}
}
