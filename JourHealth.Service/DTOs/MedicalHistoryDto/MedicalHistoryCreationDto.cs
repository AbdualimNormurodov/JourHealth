﻿using JourHealth.Domain.Entites;
using JourHealth.Service.DTOs.PatientDto;

namespace JourHealth.Service.DTOs.MedicalHistoryDto;

public class MedicalHistoryCreationDto
{
    public string DoctorSpeciality { get; set; }
    public string DoctorFullName { get; set; }
    public string Symptoms { get; set; }
    public string Diagnosis { get; set; }
    public string TypeOfCure { get; set; }
    public string Recipe { get; set; }
    public DateTime InspectionTime { get; set; }
    public long PatienId { get; set; }
    public PatientResultDto Patient { get; set; }
}