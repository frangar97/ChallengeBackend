using Core.Base;

namespace Core.EmployeeType
{
    public class EmployeeTypeEntity:BaseEntity
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
