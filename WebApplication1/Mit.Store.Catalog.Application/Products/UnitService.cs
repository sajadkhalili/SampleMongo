using WebApplication1.Mit.Store.Catalog.Application.Contracts.Units;
using WebApplication1.Mit.Store.Catalog.Domain.Units;

namespace WebApplication1.Mit.Store.Catalog.Application.Contracts.Products
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository _repository;

        public UnitService(IUnitRepository repository)
        {
            this._repository = repository;
        }
        public Task CreateUnitAsync(CreateUnit createUnit)
        {
            throw new NotImplementedException();
        }

        public Task DeActiveUnitAsync(DeActiveUnit deActiveUnit)
        {
            throw new NotImplementedException();
        }

        public async Task EditUnitAsync(EditUnit editUnit)
        {
            var unit = await _repository.GetUnitAsync(editUnit.Id);

        }
    }
}
