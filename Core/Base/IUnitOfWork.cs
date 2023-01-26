using Core.Employee;
using Core.EmployeeType;
using Core.Shop;
using Core.ShopEmployee;

namespace Core.Base
{
    public interface IUnitOfWork:IDisposable
    {
        public IRepository<EmployeeTypeEntity> EmployeeTypeRepository { get; }
        public IEmployeeRepository EmployeeRepository { get;  }
        public IRepository<ShopEntity> ShopRepository { get; }
        public IShopEmployeeRepository ShopEmployeeRepository { get; }

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
