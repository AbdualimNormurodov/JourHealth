using JourHealth.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourHealth.DAL.IRepositories
{
    public interface IRepository<T> where T : Auditable
    {
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> SelectByIdAsync(long id);
        IQueryable<T> SelectAll();
       // Task SaveAsync();
    }
}
