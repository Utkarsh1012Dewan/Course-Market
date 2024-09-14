using backend.Context;
using backend.Models;

namespace backend.Repositories
{
    public class ProjectRepository : BaseRepository<Project>
    {
        private readonly SQLDbContext context;

        public ProjectRepository(SQLDbContext context) : base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

    }
}
