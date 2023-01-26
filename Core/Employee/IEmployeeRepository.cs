using Core.Base;

namespace Core.Employee
{
    public interface IEmployeeRepository:IRepository<EmployeeEntity>
    {
        Task<IEnumerable<EmployeeEntity>> GetAllWithRelations();
    }
}
