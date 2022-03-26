namespace MemorabiliaManager.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public ItemCategory ItemCategory { get; set; } = new ItemCategory();
        public string Name { get; set; } = string.Empty;
        public int ItemCategoryId { get; set; } = 0;
    }
}
