using Domain.Entities;

namespace RepositoryPattern.API.FileUploadExtension
{
    public interface IPostService
    {
        Task SavePostImageAsync(Movie _movie);
    }
}
