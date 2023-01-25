namespace Core.Shop.services
{
    public interface IShopService
    {
        IEnumerable<ShopEntity> GetAll();
        Task CreateShop(ShopEntity entity);
    }
}
