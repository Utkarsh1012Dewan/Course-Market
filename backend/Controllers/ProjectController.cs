using backend.Models;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProjectByIdAsync(string id)
        {
            var project = await projectService.GetProjectByIdAsync(id);
            return Ok(project);
        }

        [HttpPost]
        public async Task<ActionResult<Project>> CreateProjectAsync(Project project)
        {
            var createdProject = await projectService.CreateProjectAsync(project);
            return Ok(createdProject);
        }

        [HttpPut]
        public async Task<ActionResult<Project>> UpdateProjectAsync(Project project)
        {
            await projectService.UpdateProjectAsync(project);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProjectAsync(string id)
        {
            await projectService.DeleteProjectByIdAsync(id);
            return Ok();
        }

    }
}
