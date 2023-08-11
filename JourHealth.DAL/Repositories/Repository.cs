using JourHealth.DAL.Contexts;
using JourHealth.DAL.IRepositories;
using JourHealth.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace JourHealth.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly AppDbContext appDbContext;

    public Repository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public async Task CreateAsync(T entity)
    {
        entity.CreatedAt= DateTime.UtcNow;
        await this.appDbContext.Set<T>().AddAsync(entity);
    }
    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        this.appDbContext.Entry(entity).State=EntityState.Modified;
    }
    public void Delete(T entity)
    {
        this.appDbContext.Set<T>().Remove(entity);
    }

    public Task<T> SelectByIdAsync(long id)
    
        =>this.appDbContext.Set<T>().FirstOrDefaultAsync(appDbContext=>appDbContext.Id == id);

    public IQueryable<T> SelectAll()
    
        =>this.appDbContext.Set<T>().AsNoTracking().AsQueryable();

    public Task SaveAsync()
         => this.appDbContext.SaveChangesAsync();
}
