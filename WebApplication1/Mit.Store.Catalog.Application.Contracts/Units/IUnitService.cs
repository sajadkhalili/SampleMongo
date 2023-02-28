namespace WebApplication1.Mit.Store.Catalog.Application.Contracts.Units
{
    public interface IUnitService
    {
        public Task CreateUnitAsync(CreateUnit createUnit);
        public Task EditUnitAsync(EditUnit editUnit);
        public Task DeActiveUnitAsync(DeActiveUnit deActiveUnit);

    }
}
