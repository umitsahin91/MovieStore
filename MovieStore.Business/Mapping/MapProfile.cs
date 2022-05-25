using AutoMapper;
using MovieStore.DTO.Response.Director;
using MovieStore.DTO.Response.Genre;
using MovieStore.DTO.Response.Movie;
using MovieStore.Entities;

namespace MovieStore.Business.Mapping;

public class MapProfile:Profile
{
    public MapProfile()
    {
        
        CreateMap<Movie, GetMoviesDto>();
        CreateMap<Movie, GetMovieByIdDto>();


        CreateMap<Director, GetDirectorsDto>();
        CreateMap<Director, GetDirectorByIdDto>();

        CreateMap<Genre, GetGenresDto>();
        CreateMap<Genre,GetGenreByIdDto>();
    }
}
