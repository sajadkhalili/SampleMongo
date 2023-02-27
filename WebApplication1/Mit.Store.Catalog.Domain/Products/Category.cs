namespace WebApplication1.Mit.Store.Catalog.Domain.Products
{
    public class Category
    {
        public long Id { get; set; }
        public long? Parent { get; set; }
        public string Title { get; set; }
    }
}
