using JourHealth.DAL.Contexts;
using JourHealth.DAL.IRepositories;
using JourHealth.Domain.Commons;

namespace JourHealth.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly AppDbContext appDbContext;
    public Repository()
    {
        this.appDbContext = new AppDbContext();
    }
    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }
    public Task Update(T entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> SelectAll()
    {
        throw new NotImplementedException();
    }

}
