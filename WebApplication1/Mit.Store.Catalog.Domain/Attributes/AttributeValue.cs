namespace WebApplication1.Mit.Store.Catalog.Domain.Attributes
{
    public class AttributeValue<T>
    {
        public long Key { get; set; }
        public T Value { get; set; }
    }



    public enum DataType
    {
        String = 1,
        Boolean = 2
    }
    public class AttributeValue : AttributeValue<string>
    {

    }
}
