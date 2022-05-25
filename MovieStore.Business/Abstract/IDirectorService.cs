using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Abstract
{
    public interface IDirectorService
    {
        Task<Director> GetByIdAsync(int id);
        Task<List<Director>> GetAllAsync();
    }
}
