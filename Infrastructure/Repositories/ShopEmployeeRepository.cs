using Core.ShopEmployee;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Infrastructure.Repositories
{
    public class ShopEmployeeRepository : Repository<ShopEmployeeEntity>, IShopEmployeeRepository
    {
        public ShopEmployeeRepository(ChallengeContext challengeContext) : base(challengeContext)
        {
        }

        public async Task<IEnumerable<ShopEmployeeEntity>> GetAllWithRelations()
        {
            return await _entities.Include(x => x.Shop).Include(y => y.Employee).ToListAsync();
        }
    }
}
