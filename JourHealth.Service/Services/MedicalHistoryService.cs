using AutoMapper;
using JourHealth.DAL.IRepositories;
using JourHealth.DAL.Repositories;
using JourHealth.Domain.Entites;
using JourHealth.Service.DTOs.MedicalHistoryDto;
using JourHealth.Service.DTOs.PatientDto;
using JourHealth.Service.Interfaces;
using JourHealth.Service.Mapper;
using Microsoft.EntityFrameworkCore;

namespace JourHealth.Service.Services;

public class MedicalHistoryService : IMedicalHistoryService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    public MedicalHistoryService()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new AutoMapper.Mapper(new MapperConfiguration(c =>
        {
            c.AddProfile<MappingProfile>();
        }));
    }
    public async Task<MedicalHistoryResultDto> AddAsync(MedicalHistoryCreationDto dto)
    {
        var medicalHistory = mapper.Map<MedicalHistory>(dto);
        Console.WriteLine(medicalHistory.DoctorSpeciality);
        await this.unitOfWork.MedicalHistoryRepository.CreateAsync(medicalHistory);
       // await this.unitOfWork.SaveAsync();
        
        Console.WriteLine(medicalHistory.DoctorSpeciality);
        var result=this.mapper.Map<MedicalHistoryResultDto>(medicalHistory);
        return result;
    }

    public async Task<IEnumerable<MedicalHistoryResultDto>> GetAllAsync(MedicalHistoryCreationDto dto)
    {
        var medicalHistories = await this.unitOfWork.MedicalHistoryRepository.SelectAll().ToListAsync();
        foreach (var item in medicalHistories)
        {
            MedicalHistory medicalHistory = await this.unitOfWork.MedicalHistoryRepository.SelectByIdAsync(item.Id);
        }
        var result = this.mapper.Map<IEnumerable<MedicalHistoryResultDto>>(medicalHistories);
        return result;
    }

    public async Task<MedicalHistoryResultDto> GetByIdAsync(long Id)
    {
        MedicalHistory existMedicalHistory = await this.unitOfWork.MedicalHistoryRepository.SelectByIdAsync(Id);
        if (existMedicalHistory is null)
        {
            return null;
        }


        var result = this.mapper.Map<MedicalHistoryResultDto>(existMedicalHistory);

        return result;
    }

    public async Task<List<MedicalHistoryResultDto>> MedicalHistotySearch(long patientId)
    {
        List<MedicalHistory> existMedicalHistory = this.unitOfWork
            .MedicalHistoryRepository.SelectAll().ToList();
        var temp = existMedicalHistory.Where(p => p.PatienId== patientId).ToList();
        var result = this.mapper.Map<List<MedicalHistoryResultDto>>(temp);
        return result;
    }

    public async Task<MedicalHistoryResultDto> ModifyAsync(MedicalHistoryUpdateDto dto)
    {
        MedicalHistory existMedicalHistory = await this.unitOfWork.MedicalHistoryRepository.SelectByIdAsync(dto.Id);
        if (existMedicalHistory is null)
        {
            return null;
        }
        var mappedMedicalHistory = this.mapper.Map(dto, existMedicalHistory);
        this.unitOfWork.MedicalHistoryRepository.Update(mappedMedicalHistory);
        await this.unitOfWork.MedicalHistoryRepository.SaveAsync();

        var result = this.mapper.Map<MedicalHistoryResultDto>(mappedMedicalHistory);
        return result;
    }

    public async Task<bool> RemoveAsync(long Id)
    {
        MedicalHistory existMedicalHistory =await this.unitOfWork.MedicalHistoryRepository.SelectByIdAsync(Id);
        if (existMedicalHistory is null)
        {
            return false;
        }
        this.unitOfWork.MedicalHistoryRepository.Delete(existMedicalHistory);
        await this.unitOfWork.MedicalHistoryRepository.SaveAsync();
        return true;
    }

    
}
