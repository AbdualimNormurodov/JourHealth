

using AutoMapper;
using JourHealth.DAL.IRepositories;
using JourHealth.DAL.Repositories;
using JourHealth.Domain.Entites;
using JourHealth.Service.DTOs.PatientDto;
using JourHealth.Service.Interfaces;
using JourHealth.Service.Mapper;
using Microsoft.EntityFrameworkCore;

namespace JourHealth.Service.Services;

public class PatientService : IPatientService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    public PatientService()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new AutoMapper.Mapper(new MapperConfiguration(c =>
        {
            c.AddProfile<MappingProfile>();
        }));
    }
    //private readonly IRepository<Patient> repository;
    //private readonly IMapper mapper;

    //public PatientService()
    //{
    //}

    //public PatientService(IRepository<Patient> repository)
    //{
    //    this.repository = repository;
    //    this.mapper = new AutoMapper.Mapper(new MapperConfiguration(c => { c.AddProfile<MappingProfile>(); }));
    //}

    public async Task<PatientResultDto> AddAsync(PatientCretionDto dto)
    {
        var patient = mapper.Map<Patient>(dto);
       
        await this.unitOfWork.PatientRepository.CreateAsync(patient);
        this.unitOfWork.PatientRepository.SaveAsync();
       
        var result = this.mapper.Map<PatientResultDto>(patient);
        return result;  
    }

    public async Task<bool> CheckId(long Id)
    {
        var patient= await this.unitOfWork.PatientRepository.SelectByIdAsync(Id);
        if(patient == null)
            return false;

        return true;
    }

    public async Task<IEnumerable<PatientResultDto>> GetAllAsync(PatientCretionDto dto)
    {
        var patients=await this.unitOfWork.PatientRepository.SelectAll().ToListAsync();
        foreach (var item in patients)
        {
            Patient patient = await this.unitOfWork.PatientRepository.SelectByIdAsync(item.Id);
        }
        var result = this.mapper.Map<IEnumerable<PatientResultDto>>(patients);
        return result;

    }

    public async Task<PatientResultDto> GetByIdAsync(long Id)
    {
        Patient existPatient=await this.unitOfWork.PatientRepository.SelectByIdAsync(Id);
        if (existPatient is null)
        {
            return null;
        }
    
        
        var result=this.mapper.Map<PatientResultDto>(existPatient);
       
        return result;
    }

    public async Task<PatientResultDto> ModifyAsync(PatientUpdateDto dto)
    {
        Patient existPatient= await this.unitOfWork.PatientRepository.SelectByIdAsync(dto.Id);
        if (existPatient is null) 
        {
            return null;
        }
        var mappedPatient=this.mapper.Map(dto,existPatient);
        this.unitOfWork.PatientRepository.Update(mappedPatient);
        await this.unitOfWork.PatientRepository.SaveAsync();

        var result =this.mapper.Map<PatientResultDto>(mappedPatient);
        return result;
    }

    public async Task<bool> RemoveAsync(long Id)
    {
        Patient existPatient = await this.unitOfWork.PatientRepository.SelectByIdAsync(Id);
        if (existPatient is null)
        {
            return false;
        }
        this.unitOfWork.PatientRepository.Delete(existPatient);
        await this.unitOfWork.PatientRepository.SaveAsync();
        return true;
    }
}
