using Core.Base;

namespace Core.Shop.services
{
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork unitOfWork;

        public ShopService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task CreateShop(ShopEntity entity)
        {
            await unitOfWork.ShopRepository.AddAsync(entity);
            await unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<ShopEntity> GetAll()
        {
            return unitOfWork.ShopRepository.GetAll();
        }
    }
}
