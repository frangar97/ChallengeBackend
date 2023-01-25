using Core.Base;
using Core.EmployeeType;
using Core.ShopEmployee;

namespace Core.Employee
{
    public class EmployeeEntity:BaseEntity
    {
        public string Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime EmploymentDate { get; set; }

        public EmployeeTypeEntity EmployeeType { get; set; }
        public ICollection<ShopEmployeeEntity> ShopEmployees { get; set; }
    }
}
