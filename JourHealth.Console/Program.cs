using AutoMapper;
using JourHealth.Print.Views;
using JourHealth.Service.DTOs.MedicalHistoryDto;
using JourHealth.Service.DTOs.PatientDto;
using JourHealth.Service.Interfaces;
using JourHealth.Service.Services;
using System.Security.Claims;

//IPatientService patientService=new PatientService();
//var patient = new PatientCretionDto()
//{
//    Address = "Samarkand",
//    DateOfBirth = DateTime.UtcNow,
//    Email = "Samarkand@gmail.com",
//    FirstName = "Ali",
//    LastName = "Valiyev",
//    Phone = "+998995555555",
//    Gender = "Male"
//};

//var res = await patientService.AddAsync(patient);
//Console.WriteLine(res.FirstName);

//var result = await patientService.GetByIdAsync(1);
//Console.WriteLine($"ID:{result.Id} | Name:{result.FirstName} | LastName:{result.LastName} | ");

//IMedicalHistoryService medicalHistoryService= new MedicalHistoryService();
//var result = await medicalHistoryService.GetByIdAsync(7);
//Console.WriteLine($"ID:{result.DoctorFullName} | Speciality:{result.DoctorSpeciality} | Name:{result.DoctorFullName}");

//var medicalHistory = new MedicalHistoryCreationDto() 
//{ 
//    DoctorSpeciality="Pediatr",
//    DoctorFullName="Vali Aliyev",
//    Symptoms="Headache",
//    Diagnosis="Breeze",
//    Recipe="Aspirin",
//    TypeOfCure="Light",
//    InspectionTime=DateTime.UtcNow,
//    PatienId=2
//};
//var res=await medicalHistoryService.AddAsync(medicalHistory);
//Console.WriteLine(res.DoctorFullName);

//var result = await medicalHistoryService.MedicalHistotySearch(1);
//for (int i = 0; i < result.Count; i++)
//{
//    Console.WriteLine($"Kasallik:{result[i].Symptoms} | Diagnoz:{result[i].Diagnosis} | Retsept:{result[i].Recipe}");
//}
var mainPage=new MainPage();
mainPage.View();
