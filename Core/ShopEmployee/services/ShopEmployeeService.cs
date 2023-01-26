using Core.Base;
using Core.Exceptions;

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
            var shopEmployees = unitOfWork.ShopEmployeeRepository.GetAll();

            var entityFound = shopEmployees.FirstOrDefault(x => DateTime.Equals(x.WorkDate, entity.WorkDate) && x.EmployeeId==entity.EmployeeId);

            if (entityFound != null)
            {
                throw new BusinessException("Employee cannot work on two different shops the same date");
            }

            await unitOfWork.ShopEmployeeRepository.AddAsync(entity);
            await unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<ShopEmployeeEntity> GetAll()
        {
           return unitOfWork.ShopEmployeeRepository.GetAll();
        }
    }
}
