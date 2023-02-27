using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SharpCompress.Common;
using System.Data.Common;
using WebApplication1.Mit.Store.Catalog.Domain.Attributes;
using WebApplication1.Mit.Store.Catalog.Domain.Units;

namespace WebApplication1.Mit.Store.Catalog.MongoDB.Commons
{



    public class TestContextMongoContext : SSFMongoContext
    {
        public TestContextMongoContext(IOptions<MongoConnectionOptions> dbOptions) : base(dbOptions)
        {
        }

        public IMongoCollection<ProductAttribute> ProductAttributes => Collection<ProductAttribute>();

        public IMongoCollection<Unit> Units => Collection<Unit>();
    }
}
