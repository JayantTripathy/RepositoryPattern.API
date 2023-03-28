using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.API.FileUploadExtension;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private readonly ILogger<MoviesController> logger;
        private readonly IPostService postService;
        public MoviesController(IRepositoryWrapper repository, IPostService postService, ILogger<MoviesController> logger)
        {
            _repository = repository;
            this.postService = postService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var movies = await _repository.Movie.GetAll();
            return Ok(movies);
        }

        [HttpGet]
        [Route("getbyId/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var movies = await _repository.Movie.GetById(id);
            return Ok(movies);
        }

        [HttpPost]
        [RequestSizeLimit(5 * 1024 * 1024)]
        public async Task<IActionResult> PostAsync([FromForm] Movie movieRequest)
        {
            if (movieRequest == null)
            {
                return BadRequest(new PostResponse { Success = false, ErrorCode = "S01", Error = "Invalid post request" });
            }

            if (string.IsNullOrEmpty(Request.GetMultipartBoundary()))
            {
                return BadRequest(new PostResponse { Success = false, ErrorCode = "S02", Error = "Invalid post header" });
            }

            if (movieRequest.Images != null)
            {
                await postService.SavePostImageAsync(movieRequest);
            }
            _repository.Movie.Create(movieRequest);
            _repository.Save();
            return Ok();
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAsync(int id, [FromForm] Movie movieRequest)
        {

            try
            {
                if (id != movieRequest.Id)
                    return BadRequest("ID mismatch");

                var movieToUpdate = await _repository.Movie.GetById(id);

                if (movieToUpdate == null)
                    return NotFound($"Movie with Id = {id} not found");

                movieToUpdate.Name = movieRequest.Name;
                movieToUpdate.MovieType = movieRequest.MovieType;
                movieToUpdate.Duration = movieRequest.Duration;
                movieToUpdate.Language = movieRequest.Language;
                movieToUpdate.Description = movieRequest.Description;
                movieToUpdate.ReleaseDate = movieRequest.ReleaseDate;
                if (movieRequest.ImagePath != null){
                    movieToUpdate.ImagePath = movieRequest.ImagePath;
                    await postService.SavePostImageAsync(movieRequest);
                }
                movieToUpdate.UpdatedDate = DateTime.Now;
                _repository.Movie.Update(movieToUpdate);
                _repository.Save();
                return Ok(movieToUpdate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
    
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var moviedetails = await _repository.Movie.GetById(id);
            if (moviedetails == null)
            {
                return NotFound();
            }
            _repository.Movie.Delete(moviedetails);
            _repository.Save();
            return Ok("Record Deleted Successfully");
        }
    }
}
