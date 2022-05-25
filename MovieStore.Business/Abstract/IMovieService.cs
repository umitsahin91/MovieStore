using MovieStore.DTO.Response;
using MovieStore.DTO.Response.Movie;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Abstract
{
    public interface IMovieService
    {
        Task<GetMovieByIdDto> GetByIdAsync(int id);
        Task<List<GetMoviesDto>> GetAllAsync();
    }
}
