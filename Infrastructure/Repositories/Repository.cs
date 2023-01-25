using Core.Base;
using Persistence;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ChallengeContext _challengeContext;

        public Repository(ChallengeContext challengeContext)
        {
            _challengeContext = challengeContext;
        }

        public async Task AddAsync(T Entity)
        {
            await _challengeContext.Set<T>().AddAsync(Entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _challengeContext.Set<T>().AsEnumerable();
        }
    }
}
