using MongoDB.Driver;
using SharpCompress.Common;
using WebApplication1.Attributes.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using WebApplication1.Mit.Store.Catalog.MongoDB.Commons;
using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.Infra
{

    public class AttributeRepository : IAttributeRepository
    {
        private readonly TestContextMongoContext mongoContext;

        public AttributeRepository(TestContextMongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }


        public async Task AddAttribute(ProductAttribute productAttribute)
        {
   
           await mongoContext.ProductAttributes.InsertOneAsync(productAttribute); 
  
        }

        public async Task<ProductAttribute> GetAttributeById(string id)
        {


      
            IAsyncCursor<ProductAttribute> d = await mongoContext.ProductAttributes.FindAsync(x => x.Id ==id);
            return d.SingleOrDefault();

        }
    }
}
