using backend.Models.DTOs;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;

namespace backend.Models
{
    public class Project : BaseModel
    {
        public required string Name { get; set; }

        public required string Author { get; set; }

        public required string Category { get; set; }

        //This is going to be a URL from abs buckets
        public required string Thumbnail { get; set; }

        public required string Description { get; set; }

        public ProjectDTO ToProjectDTO()
        {
            return new ProjectDTO
            {
                Name = Name,
                Author = Author,
                Category = Category,
                Thumbnail = Thumbnail,
                Description = Description
            };
        }
    }
}
