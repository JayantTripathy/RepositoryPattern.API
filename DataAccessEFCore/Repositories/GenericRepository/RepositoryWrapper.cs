using DataAccessEFCore.DataContext;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEFCore.Repositories.GenericRepository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private ApplicationContext _appContext;
        private IMoviesRepository _movie;
        public IMoviesRepository Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = new MoviesRepository(_appContext);
                }
                return _movie;
            }
        }
        public RepositoryWrapper(ApplicationContext applicationContext)
        {
            _appContext = applicationContext;
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }
    }
}
