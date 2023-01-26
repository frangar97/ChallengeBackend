namespace Core.Employee.services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeEntity>> GetAll();
        Task CreateEmployee(EmployeeEntity entity);
    }
}
