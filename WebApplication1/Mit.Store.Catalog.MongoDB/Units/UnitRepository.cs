using MongoDB.Driver;
using WebApplication1.Mit.Store.Catalog.Domain.Units;
using WebApplication1.Mit.Store.Catalog.MongoDB.Commons;

namespace WebApplication1.Mit.Store.Catalog.MongoDB.Units
{
    public class UnitRepository: IUnitRepository
    {
        private readonly TestContextMongoContext _context;

        public UnitRepository(TestContextMongoContext context)
        {
            this._context = context;
        }

        public async Task<Unit> GetUnitAsync(string id)
        {

            return await _context.Units.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateUnitAssync(Unit unit)
        {
            var d=Builders<Unit>.Filter.Eq(w=>w.Id,unit.Id);   
            await _context.Units.UpdateOneAsync(d, unit,null);

            UpdateDefinition()
            await _context.Units.ReplaceOneAsync(x=>x.Id==unit.Id, unit);
        }
    
    }
}
