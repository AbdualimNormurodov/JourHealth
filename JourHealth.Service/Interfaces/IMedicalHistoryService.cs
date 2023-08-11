using JourHealth.Service.DTOs.MedicalHistoryDto;

namespace JourHealth.Service.Interfaces;

public interface IMedicalHistoryService
{
    Task<MedicalHistoryResultDto> AddAsync(MedicalHistoryCreationDto dto);
    Task<MedicalHistoryResultDto> ModifyAsync(MedicalHistoryUpdateDto dto);
    Task<bool> RemoveAsync(long Id);
    Task<MedicalHistoryResultDto> GetByIdAsync(long Id);
    Task<IEnumerable<MedicalHistoryResultDto>> GetAllAsync(MedicalHistoryCreationDto dto);
    Task<List<MedicalHistoryResultDto>> MedicalHistotySearch(long patientId);
}