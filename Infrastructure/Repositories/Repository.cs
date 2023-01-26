using Core.Base;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ChallengeContext _challengeContext;
        protected readonly DbSet<T> _entities;

        public Repository(ChallengeContext challengeContext)
        {
            _challengeContext = challengeContext;
            _entities=challengeContext.Set<T>();
        }

        public async Task AddAsync(T Entity)
        {
            await _entities.AddAsync(Entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
    }
}
