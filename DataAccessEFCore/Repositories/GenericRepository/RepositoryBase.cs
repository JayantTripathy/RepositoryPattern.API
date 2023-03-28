using DataAccessEFCore.DataContext;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessEFCore.Repositories.GenericRepository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public RepositoryBase(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll() => _context.Set<T>().AsNoTracking();

        public async Task<T> GetById(int id) => await _context.Set<T>().FindAsync(id);
        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);
 
    }
}
