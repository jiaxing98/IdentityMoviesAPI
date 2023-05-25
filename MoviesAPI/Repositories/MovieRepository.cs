using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Dtos;

namespace MoviesAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieAPIContext _context;
        private readonly IMapper _mapper;

        public MovieRepository(MovieAPIContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public async Task<MovieDto> CreateMovie(MovieDto dto)
        //{
        //    //Movie movie = _mapper.Map<Movie>(dto);
        //    //_context.Movies.Add(movie);

        //    //await _context.SaveChangesAsync();
        //    //return _mapper.Map<MovieDto>(movie);
        //}

        //public async Task<MovieDto> GetMovieById(int movieId)
        //{
        //    Movie movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
        //    return _mapper.Map<MovieDto>(movie);
        //}

        //public async Task<IEnumerable<MovieDto>> GetMovies()
        //{
        //    List<Movie> movieList = await _context.Movies.ToListAsync();
        //    return _mapper.Map<List<MovieDto>>(movieList);
        //}

        //public async Task<MovieDto> UpdateMovie(MovieDto dto)
        //{
        //    Movie movie = _mapper.Map<MovieDto, Movie>(dto);
        //    _context.Movies.Update(movie);

        //    await _context.SaveChangesAsync();
        //    return _mapper.Map<Movie, MovieDto>(movie);
        //}

        //public async Task<bool> DeleteMovie(int movieId)
        //{
        //    try
        //    {
        //        Movie movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
        //        if (movie == null) return false;

        //        _context.Movies.Remove(movie);
        //        await _context.SaveChangesAsync();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
