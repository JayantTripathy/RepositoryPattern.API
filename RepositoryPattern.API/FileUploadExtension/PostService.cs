using Domain.Entities;
using System;

namespace RepositoryPattern.API.FileUploadExtension
{
    public class PostService : IPostService
    {
        private readonly IWebHostEnvironment environment;
        public PostService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }
        public async Task SavePostImageAsync(Movie _movie)
        {
            var uniqueFileName = FileHelper.GetUniqueFileName(_movie.Images.FileName);

            var uploads = Path.Combine(environment.ContentRootPath, "Images");

            var filePath = Path.Combine(uploads, uniqueFileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            await _movie.Images.CopyToAsync(new FileStream(filePath, FileMode.Create));

            _movie.ImagePath = uniqueFileName;

            return;
        }
    }
}
