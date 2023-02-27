using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.Attributes.ContractService
{
    public interface IAttributeService
    {
        Task<ProductAttribute> GetAttributeById(string id);
         Task AddAttribute(ProductAttribute productAttribute);
    }
}
