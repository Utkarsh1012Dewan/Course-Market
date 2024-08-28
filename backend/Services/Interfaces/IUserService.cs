using backend.Models;
using backend.Models.DTOs;
using backend.Services.Common;

namespace backend.Services.Interfaces
{
    public interface IUserService : ICommonService<User>
    {
        Task<User> GetUserByIdAsync(string id);
        Task<User> CreateUserAsync(UserDTO user);
        Task UpdateUserAsync(UserDTO user);
        Task DeleteUserByIdAsync(string id);
    }
}
