using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace backend.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<T> GetByIdAsync(string id);
        Task<T> CreateItemAsync (T item);
        Task UpdateItemAsync(T item);
        Task DeleteByIdAsync(string id);
    }
}
