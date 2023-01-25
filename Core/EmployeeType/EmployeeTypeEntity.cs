using Core.Base;
using Core.Employee;

namespace Core.EmployeeType
{
    public class EmployeeTypeEntity:BaseEntity
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
