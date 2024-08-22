using backend.Context;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly SQLDbContext context;

        public BaseRepository(SQLDbContext context)
        {
            this.context = context;
        }

        public abstract void AddId(T item);

        public async Task<T> CreateItemAsync(T item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.createTime = DateTime.Now;
            item.updateTime = DateTime.Now;
            var response = await context.Set<T>().AddAsync(item);
            await context.SaveChangesAsync();
            return response.Entity;
        }

        public async Task DeleteByIdAsync(string id)
        {
            var item = await context.Set<T>().SingleOrDefaultAsync(x => x.Id == id);

            if (item != null)
            {
                context.Set<T>().Remove(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var response = await context.Set<T>().SingleOrDefaultAsync(x => x.Id == id);

            if (response == null) {
                throw new Exception("Item not found");
            }

            return response;
        }

        public async Task UpdateItemAsync(T item)
        {
            item.updateTime = DateTime.UtcNow;
            context.Set<T>().Update(item);
            await context.SaveChangesAsync();
        }
    }
}
