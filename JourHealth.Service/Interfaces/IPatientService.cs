using JourHealth.Service.DTOs.PatientDto;

namespace JourHealth.Service.Interfaces;

public interface IPatientService
{
    Task<PatientResultDto> AddAsync(PatientCretionDto dto);
    Task<PatientResultDto> ModifyAsync(PatientUpdateDto dto);
    Task<bool> RemoveAsync(long Id);
    Task <PatientResultDto> GetByIdAsync(long Id);
    Task<bool> CheckId(long Id);
    Task<IEnumerable<PatientResultDto>> GetAllAsync(PatientCretionDto dto);
}
