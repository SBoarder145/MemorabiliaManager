namespace MemorabiliaManager.Domain
{
	public class EntertainmentCategory
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<Entertainment> Entertainment { get; set; } = new List<Entertainment>();
	}
}