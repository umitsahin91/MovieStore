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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Genre>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Genre> GetByIdAsync(int id)
        {
           return await _repository.GetByIdAsync(id);
        }
    }
}
