namespace backend.Models
{
    public class Video: BaseModel
    {
        public required string FileName { get; set; }
        public required string VideoUrl { get; set; }
        public required string ProjectId { get; set; }
    }
}
