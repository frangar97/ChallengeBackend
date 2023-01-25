using Core.Base;

namespace Core.EmployeeType.services
{
    public class EmployeeTypeService : IEmployeeTypeService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeTypeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task CreateEmployeeType(EmployeeTypeEntity entity)
        {
            await unitOfWork.EmployeeTypeRepository.AddAsync(entity);
            await unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<EmployeeTypeEntity> GetAll()
        {
            return unitOfWork.EmployeeTypeRepository.GetAll();
        }
    }
}
