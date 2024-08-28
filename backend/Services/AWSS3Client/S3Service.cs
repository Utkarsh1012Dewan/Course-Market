
using Amazon.Extensions.NETCore.Setup;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualBasic;

namespace backend.Services.AWSS3Client
{
    public class S3Service : IS3Service
    {
        public readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public S3Service(IConfiguration configuration, IAmazonS3 s3Client)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _bucketName = configuration["AWS:S3Bucket"];

            if (string.IsNullOrEmpty(_bucketName))
            {
                throw new ArgumentException("S3 bucket name is not configured.");
            }
        }
        public Task<List<string>> GetVideosAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Amazon s3 service to upload a video file to an s3 bucket
        /// </summary>
        /// <param name="file"></param>
        /// <param name="courseName"></param>
        /// <returns></returns>
        public async Task<string> UploadVideosAsync(IFormFile file,string courseName)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var folder = $"videos/{courseName}/";
            var filepath = $"{folder}{fileName}";

            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;

            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = filepath,
                InputStream = ms,
                ContentType = file.ContentType
            };

            await _s3Client.PutObjectAsync(request);
            return $"https://{_bucketName}.s3.amazonaws.com/{filepath}";
        }

        /// <summary>
        /// Amazon s3 service for uploading video thumbnail to s3 bucket
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<string> UploadThumbnailAsync(IFormFile File,string courseName)
        {
            var filename = $"{courseName}/{Guid.NewGuid()}";
            var folder = $"thumbnails/";
            var filepath = $"{folder}/{filename}";

            using var ms = new MemoryStream();
            await File.CopyToAsync(ms);
            ms.Position = 0;
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = filepath,
                InputStream = ms,
                ContentType = File.ContentType,

            };
            await _s3Client.PutObjectAsync(request);
            return $"https:/{_bucketName}.s3.amazonaws.com/{filepath}";
        }
    }
}
