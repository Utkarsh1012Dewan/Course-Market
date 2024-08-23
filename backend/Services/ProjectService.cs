using backend.Models;
using backend.Models.DTOs;
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
        public async Task<Project> CreateProjectAsync(ProjectDTO project)
        {
            var response = await baseRepository.CreateItemAsync(project.ToProject());
            return response;
        }

        public async Task DeleteProjectByIdAsync(string id)
        {
            await baseRepository.DeleteByIdAsync(id);
        }

        public async Task<Project> GetProjectByIdAsync(string id)
        {
            var response = await baseRepository.GetByIdAsync(id);

            if (response == null)
            {
                throw new Exception("Entity not found");
            }
            return response;
        }

        public async Task UpdateProjectAsync(ProjectDTO project)
        {
            await baseRepository.UpdateItemAsync(project.ToProject());
        }
    }
}
