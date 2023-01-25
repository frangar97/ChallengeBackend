namespace Core.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task AddAsync(T entity);
    }
}
