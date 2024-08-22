namespace backend.Services.Common
{
    public interface ICommonService<T>
    {
        Task<T> GetItemByIdAsync(string id);
        Task<T> CreateItemAsync (T item);
        Task UpdateItemAsync(T item);
        Task DeleteItemByIdAsync(string id);
    }
}
