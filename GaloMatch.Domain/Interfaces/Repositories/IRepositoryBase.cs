namespace GaloMatch.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<ICollection<T>> CreateAsync(ICollection<T> entities);
        Task<bool> RemoveAsync(T entity);
        Task<bool> RemoveAsync(ICollection<T> entities);
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> ListAsync();
        Task<bool> UpdateAsync(T entity);
        Task<bool> UpdateAsync(ICollection<T> entities);
    }
}
