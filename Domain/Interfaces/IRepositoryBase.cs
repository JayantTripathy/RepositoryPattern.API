using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
