using MovieStore.DataAccess.Context;
using MovieStore.DataAccess.Repositories.Abstract;
using MovieStore.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DataAccess.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return  _context.Set<T>().ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return  _context.Set<T>().FirstOrDefault(x=>x.Id == id);
        }
    }
}
