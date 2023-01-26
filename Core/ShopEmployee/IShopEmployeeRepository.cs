using Core.Base;

namespace Core.ShopEmployee
{
    public interface IShopEmployeeRepository:IRepository<ShopEmployeeEntity>
    {
        Task<IEnumerable<ShopEmployeeEntity>> GetAllWithRelations();
    }
}
