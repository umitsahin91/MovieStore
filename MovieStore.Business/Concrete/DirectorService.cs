using MovieStore.Business.Abstract;
using MovieStore.DataAccess.Repositories.Abstract;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Concrete;

public class DirectorService : IDirectorService
{
    private readonly IDirectorRepository _repository;

    public DirectorService(IDirectorRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Director>> GetAllAsync()
    {
       return await _repository.GetAllAsync();
    }

    public async Task<Director> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}
