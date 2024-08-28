namespace backend.Services.AWSS3Client
{
    public interface IS3Service
    {
        Task<string> UploadThumbnailAsync(IFormFile File,string courseName);
        Task<string> UploadVideosAsync(IFormFile file, string courseName);
        Task<List<string>> GetVideosAsync();

    }
}
