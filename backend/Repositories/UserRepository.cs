using backend.Context;
using backend.Models;

namespace backend.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        private readonly SQLDbContext context;

        public UserRepository(SQLDbContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public override void AddId(User item)
        {
            item.Id = Guid.NewGuid().ToString();
        }
    }
}
