using backend.Repositories;
using backend.Models;
using backend.Services.Common;
using backend.Services.Interfaces;

namespace backend.Services
{
    public class UserService : CommonService<User>, IUserService
    {
        public UserService(IBaseRepository<User> userRepository) : base(userRepository)
        {
            
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            // Implementation logic for getting a user by ID
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // Implementation logic for creating a user
        }

        public async Task UpdateUserAsync(User user)
        {
            // Implementation logic for updating a user
        }

        public async Task DeleteUserByIdAsync(string id)
        {
            // Implementation logic for deleting a user by ID
        }
    }
}
