namespace backend.Services.AWSS3Client
{
    using Amazon.S3;
    using Amazon.S3.Model;
    using Amazon.S3.Transfer;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    public class S3Service : IS3Service
    {
        private readonly IAmazonS3 _s3Client;

        public S3Service(IConfiguration configuration, IAmazonS3 s3Client)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
        }

        public Task<List<string>> GetVideosAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Amazon S3 service to upload a video file to an S3 bucket
        /// </summary>
        public async Task<string> UploadToS3Async(IFormFile file, string courseName, string bucketName)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var folder = $"{courseName}/videos/";
            var filePath = $"{folder}{fileName}";

            using var fileTransferUtility = new TransferUtility(_s3Client);
            using var stream = file.OpenReadStream();

            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = stream,
                Key = filePath,
                BucketName = bucketName,
                ContentType = file.ContentType
            };

            await fileTransferUtility.UploadAsync(uploadRequest);
            return $"https://{bucketName}.s3.amazonaws.com/{filePath}";
        }

        /// <summary>
        /// Amazon S3 service for uploading video thumbnail to S3 bucket
        /// </summary>
        public async Task<string> UploadThumbnailAsync(IFormFile file, string courseName, string bucketName)
        {
            var filename = $"{courseName}/{Guid.NewGuid()}";
            var folder = $"thumbnails/";
            var filepath = $"{folder}/{filename}";

            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;

            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = filepath,
                InputStream = ms,
                ContentType = file.ContentType
            };

            await _s3Client.PutObjectAsync(request);
            return $"https://{bucketName}.s3.amazonaws.com/{filepath}";
        }

        /// <summary>
        /// Processes a list of incoming videos and uploads them to S3, generating links
        /// </summary>
        public async Task<List<string>> UploadVideosAsync(IFormFileCollection files, string courseName, string bucketName)
        {
            List<string> videos = new List<string>();

            foreach (var file in files)
            {
                var link = await UploadToS3Async(file, courseName, bucketName);
                videos.Add(link);
            }

            return videos;
        }
    }
}
