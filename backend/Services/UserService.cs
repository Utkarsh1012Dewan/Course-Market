using backend.Repositories;
using backend.Models;
using backend.Services.Common;
using backend.Services.Interfaces;
using backend.Models.DTOs;

namespace backend.Services
{
    public class UserService : CommonService<User>, IUserService
    {
        private readonly IBaseRepository<User> userRepository;

        public UserService(IBaseRepository<User> userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            var response = await userRepository.GetByIdAsync(id);
            return response;
        }

        public async Task<User> CreateUserAsync(UserDTO user)
        {
            var response = await userRepository.CreateItemAsync(user.ToUser());
            return response;
        }

        public async Task UpdateUserAsync(UserDTO user)
        {
            await userRepository.UpdateItemAsync(user.ToUser());
        }

        public async Task DeleteUserByIdAsync(string id)
        {
            await userRepository.DeleteByIdAsync(id);
        }
    }
}
