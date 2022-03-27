namespace MemorabiliaManager.Domain
{
	public class JerseyNumber
	{
		public int Id { get; set; }
		public Signature Signature { get; set; } = new Signature();
		public short Number { get; set; } = 0;
		public int SignatureId { get; set; } = 0;
	}
}
