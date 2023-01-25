using Core.Employee;
using Core.EmployeeType;
using Core.Shop;
using Core.ShopEmployee;

namespace Core.Base
{
    public interface IUnitOfWork:IDisposable
    {
        public IRepository<EmployeeTypeEntity> EmployeeTypeRepository { get; }
        public IRepository<EmployeeEntity> EmployeeRepository { get;  }
        public IRepository<ShopEntity> ShopRepository { get; }
        public IRepository<ShopEmployeeEntity> ShopEmployeeRepository { get; }

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
