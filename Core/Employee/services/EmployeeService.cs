using Core.Base;

namespace Core.Employee.services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task CreateEmployee(EmployeeEntity entity)
        {
            await unitOfWork.EmployeeRepository.AddAsync(entity);
            await unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<EmployeeEntity> GetAll()
        {
            return unitOfWork.EmployeeRepository.GetAll();
        }
    }
}
