using Newtonsoft.Json;

namespace backend.Models.DTOs
{
    public class ProjectDTO
    {
        public required string Name { get; set; }

        public required string Author { get; set; }

        public required string Category { get; set; }

        //This is going to be a URL from abs buckets
        public required string Thumbnail { get; set; }

        public required string Description { get; set; }

        public Project ToProject()
        {
            return new Project
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
