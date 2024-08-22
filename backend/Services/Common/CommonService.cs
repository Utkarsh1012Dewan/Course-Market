using backend.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace backend.Services.Common
{
    public class CommonService<T> : ICommonService<T>
    {
        private readonly IBaseRepository<T> baseRepository;

        public CommonService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<T> CreateItemAsync(T item)
        {
            var response = await baseRepository.CreateItemAsync(item);

            if (response == null)
            {
                throw new Exception("An error occured");
            }
            return response;
        }

        public async Task DeleteItemByIdAsync(string id)
        {
            await baseRepository.DeleteByIdAsync(id);
        }

        public Task<T> GetItemByIdAsync(string id)
        {
            var response = baseRepository.GetByIdAsync(id);

            if (response == null)
            {
                throw new Exception("An error occured");
            }
            return response;
        }

        public async Task UpdateItemAsync(T item)
        {
            await baseRepository.UpdateItemAsync(item);
        }
    }
}
