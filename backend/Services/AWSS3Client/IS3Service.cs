namespace backend.Services.AWSS3Client
{
    public interface IS3Service
    {
        Task<string> UploadThumbnailAsync(IFormFile File,string courseName,string bucketName);
        Task<string> UploadToS3Async(IFormFile file, string courseName, string bucketName);
        Task<List<string>> UploadVideosAsync(IFormFileCollection files, string courseName, string bucketName);
        Task<List<string>> GetVideosAsync();

    }
}
