using Core.Base;
using Core.Employee;
using Core.EmployeeType;
using Core.Shop;
using Core.ShopEmployee;
using Persistence;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ChallengeContext context;
        private  IRepository<EmployeeTypeEntity> employeeTypeRepository;
        private  IEmployeeRepository employeeRepository;
        private  IRepository<ShopEntity> shopRepository;
        private  IShopEmployeeRepository shopEmployeeRepository;

        public UnitOfWork(ChallengeContext context)
        {
            this.context = context;
        }

        public IRepository<EmployeeTypeEntity> EmployeeTypeRepository 
        { 
            get {
                if (this.employeeTypeRepository == null)
                {
                    this.employeeTypeRepository = new Repository<EmployeeTypeEntity>(context);
                }
                return this.employeeTypeRepository;
            } 
        }

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new EmployeeRepository(context);
                }
                return this.employeeRepository;
            }
        }

        public IRepository<ShopEntity> ShopRepository
        {
            get
            {
                if (this.shopRepository == null)
                {
                    this.shopRepository = new Repository<ShopEntity>(context);
                }
                return this.shopRepository;
            }
        }

        public IShopEmployeeRepository ShopEmployeeRepository 
        {
            get
            {
                if (this.shopEmployeeRepository == null)
                {
                    this.shopEmployeeRepository = new ShopEmployeeRepository(context);
                }
                return this.shopEmployeeRepository;
            }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        public int SaveChanges()
        {
            int affectedRows = context.SaveChanges();
            return affectedRows;
        }

        public async Task<int> SaveChangesAsync()
        {
            int affectedRows = await context.SaveChangesAsync();
            return affectedRows;
        }
    }
}
