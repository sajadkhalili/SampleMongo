using Mit.Store.Catalog.Attributes;
using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.Attributes.ContractService
{
    public class CreateAttribute
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public string Name { get; protected set; }
        public ElementType ElementType { get; protected set; }
        public int UnitId { get; protected set; }
        public List<AttributeValue> Values { get; protected set; }
    }
}
