namespace Core.ShopEmployee.services
{
    public interface IShopEmployeeService
    {
        Task<IEnumerable<ShopEmployeeEntity>> GetAll();
        Task CreateShopEmployee(ShopEmployeeEntity entity);
    }
}
