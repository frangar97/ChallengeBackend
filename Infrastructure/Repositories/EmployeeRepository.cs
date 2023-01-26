using Core.Employee;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(ChallengeContext challengeContext) : base(challengeContext)
        {
        }

        public async Task<IEnumerable<EmployeeEntity>> GetAllWithRelations()
        {
            return await _entities.Include(x=>x.EmployeeType).ToListAsync();
        }
    }
}
