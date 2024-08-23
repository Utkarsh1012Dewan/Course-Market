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

        //A list of urls of all the vidoes that are going to be part of the course
        public required List<string> Videos { get; set; }

        public required string Description { get; set; }

        public Project ToProject()
        {
            return new Project
            {
                Name = Name,
                Author = Author,
                Category = Category,
                Thumbnail = Thumbnail,
                Videos = JsonConvert.SerializeObject(Videos),
                Description = Description
            };
        }
    }

    
}
