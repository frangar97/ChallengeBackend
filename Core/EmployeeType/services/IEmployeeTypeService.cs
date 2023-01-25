namespace Core.EmployeeType.services
{
    public interface IEmployeeTypeService
    {
        IEnumerable<EmployeeTypeEntity> GetAll();
        Task CreateEmployeeType(EmployeeTypeEntity entity);
    }
}
