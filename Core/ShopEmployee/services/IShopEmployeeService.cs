namespace Core.ShopEmployee.services
{
    public interface IShopEmployeeService
    {
        IEnumerable<ShopEmployeeEntity> GetAll();
        Task CreateShopEmployee(ShopEmployeeEntity entity);
    }
}
