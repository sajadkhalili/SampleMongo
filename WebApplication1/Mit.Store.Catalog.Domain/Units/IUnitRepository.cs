namespace WebApplication1.Mit.Store.Catalog.Domain.Units
{
    public interface IUnitRepository
    {
        Task<Unit> GetUnitAsync(string id);
        Task   UpdateUnitAssync(Unit unit);

    }
}
