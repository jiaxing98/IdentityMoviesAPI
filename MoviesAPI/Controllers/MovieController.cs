using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Dtos;
using MoviesAPI.Repositories;

namespace MoviesAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            try
            {
                MovieDto dto = await _movieRepository.GetMovieById(id);
                return Ok(new ResponseDto
                {
                    Result = dto,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDto
                {
                    Status = Status.Failure,
                    ErrorMessage = new List<string> { ex.Message },
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            try
            {
                IEnumerable<MovieDto> dtos = await _movieRepository.GetMovies();
                return Ok(new ResponseDto
                {
                    Result = dtos,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDto
                {
                    Status = Status.Failure,
                    ErrorMessage = new List<string> { ex.Message },
                });
            }
        }

        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieDto dto)
        {
            try
            {
                MovieDto model = await _movieRepository.CreateMovie(dto);
                return Ok(new ResponseDto
                {
                    Result = model,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDto
                {
                    Status = Status.Failure,
                    ErrorMessage = new List<string> { ex.Message },
                });
            }
        }

        //[Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateMovie([FromBody] MovieDto dto)
        {
            try
            {
                MovieDto model = await _movieRepository.UpdateMovie(dto);
                return Ok(new ResponseDto
                {
                    Result = model,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDto
                {
                    Status = Status.Failure,
                    ErrorMessage = new List<string> { ex.Message },
                });
            }
        }

        //[Authorize(Roles = Roles.ADMIN)]
        [HttpDelete]
        public async Task<IActionResult> DeleteMovie([FromBody] int id)
        {
            try
            {
                bool isDeleted = await _movieRepository.DeleteMovie(id);
                return Ok(new ResponseDto
                {
                    Result = isDeleted,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseDto
                {
                    Status = Status.Failure,
                    ErrorMessage = new List<string> { ex.Message },
                });
            }
        }
    }
}
