using AutoMapper;
using MovieStore.Business.Abstract;
using MovieStore.DataAccess.Repositories.Abstract;
using MovieStore.DTO.Response.Movie;

namespace MovieStore.Business.Concrete;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _repository;
    private readonly IMapper _mapper;
    public MovieService(IMovieRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetMoviesDto>> GetAllAsync()
    {
        var movieList = await _repository.GetAllAsync();
        return _mapper.Map<List<GetMoviesDto>>(movieList);

    }

    public async Task<GetMovieByIdDto> GetByIdAsync(int id)
    {
        var movie= await _repository.GetByIdAsync(id);
        return _mapper.Map<GetMovieByIdDto>(movie);
    }
}
