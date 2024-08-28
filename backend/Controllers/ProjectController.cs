using backend.Models;
using backend.Models.DTOs;
using backend.Services.AWSS3Client;
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
        private readonly IS3Service s3Service;

        public ProjectController(IProjectService projectService,IS3Service s3Service)
        {
            this.projectService = projectService;
            this.s3Service = s3Service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProjectByIdAsync(string id)
        {
            var project = await projectService.GetProjectByIdAsync(id);
            return Ok(project);
        }

        [HttpPost("{createProject}")]
        public async Task<ActionResult<Project>> CreateProjectAsync(ProjectDTO project)
        {
            var createdProject = await projectService.CreateProjectAsync(project);
            return Ok(createdProject);
        }

        [HttpPut]
        public async Task<ActionResult<Project>> UpdateProjectAsync(ProjectDTO project)
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

        [HttpPost("thumbnail")]
        public async Task<IActionResult> UploadThumbnailAsync(string courseName, IFormFile file)
        {
            var response = await s3Service.UploadThumbnailAsync(file, courseName);
            return Ok(response);
        }
    }
}
