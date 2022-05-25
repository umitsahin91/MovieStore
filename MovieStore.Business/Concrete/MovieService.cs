using MovieStore.Business.Abstract;
using MovieStore.DataAccess.Repositories.Abstract;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Concrete
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Movie>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
