using backend.Models;
using backend.Models.DTOs;
using backend.Services.Common;

namespace backend.Services.Interfaces
{
    public interface IProjectService : ICommonService<Project>
    {
        Task<Project> GetProjectByIdAsync (string id);
        Task<Project> CreateProjectAsync(ProjectDTO project);
        Task UpdateProjectAsync(ProjectDTO project);
        Task DeleteProjectByIdAsync(string id); 
    }
}
