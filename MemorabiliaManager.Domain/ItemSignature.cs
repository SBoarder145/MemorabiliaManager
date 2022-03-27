namespace MemorabiliaManager.Domain
{
	public class ItemSignature
	{
		public int Id { get; set; }
		public Item Item { get; set; } = new Item();
		public Signature Signature { get; set; } = new Signature();
		public int ItemId { get; set; } = 0;
		public int SignatureId { get; set; } = 0;
	}
}
