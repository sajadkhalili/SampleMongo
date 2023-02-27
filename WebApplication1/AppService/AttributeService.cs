using WebApplication1.Attributes.Contract;
using WebApplication1.Attributes.ContractService;
using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.AppService
{
    public class AttributeService : IAttributeService
    {
        private readonly IAttributeRepository _repository;

        public AttributeService(IAttributeRepository repository)
        {
            this._repository = repository;
        }
        public async Task AddAttribute(ProductAttribute productAttribute)
        {
      await  _repository.AddAttribute(productAttribute); 
        }

        public async Task<ProductAttribute> GetAttributeById(string id)
        {
        return await _repository.GetAttributeById(id);        
        }
    }
}
