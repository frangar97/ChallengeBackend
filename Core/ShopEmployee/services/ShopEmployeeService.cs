using Core.Base;

namespace Core.ShopEmployee.services
{
    public class ShopEmployeeService : IShopEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;

        public ShopEmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task CreateShopEmployee(ShopEmployeeEntity entity)
        {
            await unitOfWork.ShopEmployeeRepository.AddAsync(entity);
            await unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<ShopEmployeeEntity> GetAll()
        {
           return unitOfWork.ShopEmployeeRepository.GetAll();
        }
    }
}
