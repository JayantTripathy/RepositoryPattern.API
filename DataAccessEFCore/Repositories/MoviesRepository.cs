using DataAccessEFCore.DataContext;
using DataAccessEFCore.Repositories.GenericRepository;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.Repositories
{
    public class MoviesRepository : RepositoryBase<Movie>, IMoviesRepository
    {
        public MoviesRepository(ApplicationContext applicationContext)
            : base(applicationContext)
        {
        }
    }
}
