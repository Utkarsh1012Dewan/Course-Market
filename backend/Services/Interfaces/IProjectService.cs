using backend.Models;
using backend.Services.Common;

namespace backend.Services.Interfaces
{
    public interface IProjectService : ICommonService<Project>
    {
        Task<Project> GetProjectByIdAsync (string id);
        Task<Project> CreateProjectAsync(Project project);
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectByIdAsync(string id); 
    }
}
