using JourHealth.DAL.Contexts;
using JourHealth.DAL.IRepositories;
using JourHealth.Domain.Entites;

namespace JourHealth.DAL.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext appDbContext;

    public UnitOfWork()
    {
        this.appDbContext = new AppDbContext();
        PatientRepository = new Repository<Patient>(appDbContext);
        MedicalHistoryRepository = new Repository<MedicalHistory>(appDbContext);
    }

    public IRepository<Patient> PatientRepository { get; }
    public IRepository<MedicalHistory> MedicalHistoryRepository { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public async Task SaveAsync()
    {
       await this.appDbContext.SaveChangesAsync();
    }
}
