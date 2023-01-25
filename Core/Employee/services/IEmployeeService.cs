namespace Core.Employee.services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeEntity> GetAll();
        Task CreateEmployee(EmployeeEntity entity);
    }
}
