using Core.Base;
using Core.ShopEmployee;

namespace Core.Shop
{
    public class ShopEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public ICollection<ShopEmployeeEntity> ShopEmployees { get; set; }
    }
}
