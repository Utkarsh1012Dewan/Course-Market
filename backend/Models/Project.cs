using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace backend.Models
{
    public class Project : BaseModel
    {
        public required string Name { get; set; }

        public required string Author { get; set; }

        public required string Category { get; set; }

        //This is going to be a URL from abs buckets
        public required string Thumbnail { get; set; }

        //A list of urls of all the vidoes that are going to be part of the course
        public List<string>? Videos { get; set; }

        public required string Description { get; set; }
    }
}
