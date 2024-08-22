using backend.Models;
using backend.Repositories;
using backend.Services.Common;
using backend.Services.Interfaces;

namespace backend.Services
{
    public class ProjectService : CommonService<Project>, IProjectService
    {
        private readonly IBaseRepository<Project> baseRepository;

        public ProjectService(IBaseRepository<Project> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public Task<Project> CreateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProjectByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
