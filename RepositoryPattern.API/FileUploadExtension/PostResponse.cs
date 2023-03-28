using Domain.Entities;

namespace RepositoryPattern.API.FileUploadExtension
{
    public class PostResponse : BaseResponse
    {
        public Movie Post { get; set; }
    }
}
