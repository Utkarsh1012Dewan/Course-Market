using backend.Context;
using backend.Models;

namespace backend.Repositories
{
    public class ProjectRepository : BaseRepository<Project>
    {
        public ProjectRepository(SQLDbContext context) : base(context)
        {

        }

    }
}
