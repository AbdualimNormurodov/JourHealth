using JourHealth.Domain.Entites;

namespace JourHealth.DAL.IRepositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Patient> PatientRepository { get;}
    IRepository<MedicalHistory> MedicalHistoryRepository { get;}
}
