using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.Attributes.Contract
{
    public interface IAttributeRepository
    {
         Task AddAttribute(ProductAttribute productAttribute);

        Task<ProductAttribute> GetAttributeById(string id);
    }
}
