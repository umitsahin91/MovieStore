using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieStore.DataAccess.Context;
using MovieStore.DataAccess.Repositories.Abstract;
using MovieStore.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DataAccess;

public static class ServiceRegistration
{
    public static void AddDataAccessServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieStoreDb;"));

        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IGenreRepository, GenreRepository>();
        services.AddScoped<IDirectorRepository, DirectorRepository>();

    }
}
