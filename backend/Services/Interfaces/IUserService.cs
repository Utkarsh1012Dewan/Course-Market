using backend.Models;
using backend.Services.Common;

namespace backend.Services.Interfaces
{
    public interface IUserService : ICommonService<User>
    {
        Task<User> GetUserByIdAsync(string id);
        Task<User> CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserByIdAsync(string id);
    }
}
