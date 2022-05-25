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
        Task<Movie> GetByIdAsync(int id);
        Task<List<Movie>> GetAllAsync();
    }
}
