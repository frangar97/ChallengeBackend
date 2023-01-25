using Core.Base;
using Core.Employee;
using Core.Shop;

namespace Core.ShopEmployee
{
    public class ShopEmployeeEntity:BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ShopId { get; set; }
        public DateTime WorkDate { get; set; }
        public EmployeeEntity Employee { get; set; }
        public ShopEntity Shop { get; set; }
    }
}
