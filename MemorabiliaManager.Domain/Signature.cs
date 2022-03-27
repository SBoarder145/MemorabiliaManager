namespace MemorabiliaManager.Domain
{
	public class Signature
	{
		public int Id { get; set; }
		public Entertainment Entertainment { get; set; } = new Entertainment();
		public List<ItemSignature> Items { get; set; } = new List<ItemSignature>();
		public JerseyNumber? JerseyNumber { get; set; } = null;
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int EntertainmentId { get; set; } = 0;
	}
}
