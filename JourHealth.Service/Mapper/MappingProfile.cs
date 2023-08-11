using AutoMapper;
using JourHealth.Domain.Entites;
using JourHealth.Service.DTOs.MedicalHistoryDto;
using JourHealth.Service.DTOs.PatientDto;

namespace JourHealth.Service.Mapper;

public class MappingProfile:Profile
{
	public MappingProfile()
	{
		CreateMap<Patient,PatientCretionDto>().ReverseMap();
        CreateMap<PatientUpdateDto,Patient>().ReverseMap();
        CreateMap<PatientResultDto,Patient>().ReverseMap();

        CreateMap<MedicalHistory,MedicalHistoryCreationDto>().ReverseMap();
        CreateMap<MedicalHistoryUpdateDto, MedicalHistory>().ReverseMap();
        CreateMap<MedicalHistoryResultDto, MedicalHistory>().ReverseMap();
    }
}
