using JourHealth.DAL.Contexts;
using JourHealth.DAL.Repositories;
using JourHealth.Domain.Entites;
using JourHealth.Service.DTOs.PatientDto;
using JourHealth.Service.Services;

namespace JourHealth.Print.Views.Patients;

public class PatientServiceView
{
    private readonly PatientService patientService=new PatientService();
    MedicalHistoryService MedicalHistoryService=new MedicalHistoryService();
    public async void Create()
    {
        Console.Write("Name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Surname: ");
        string LastName = Console.ReadLine();

        Console.Write("Phone number: ");
        string Phone = Console.ReadLine();

        Console.Write("Email: ");
        string Email = Console.ReadLine();

        Console.Write("Address: ");
        string Address = Console.ReadLine();

        Console.Write("Date of birth: /yyyy.mm.dd/ ");
        DateTime DateOfBitrh = DateTime.Parse(Console.ReadLine());

        Console.Write("Gender: ");
        String Gender = Console.ReadLine();
        

        PatientCretionDto patient = new PatientCretionDto();
        patient.DateOfBirth = DateOfBitrh;
        patient.FirstName = FirstName;
        patient.LastName = LastName;
        patient.Email = Email;
        patient.Phone = Phone;
        patient.Address = Address;
        patient.Gender = Gender;
        var result = await patientService.AddAsync(patient);
        await this.patientService.
        Console.WriteLine($" Id:{result.Id} | Name:{result.FirstName} | Surname: {result.LastName} " +
                          $"| Phone number: {result.Phone} | Email: {result.Email} | Address: {result.Address} " +
                          $"| Gender:{result.Gender} | Data of birth: {result.DateOfBirth} ");
        
    }


    public async void Update()

    {
        Console.WriteLine("Enter your id: ");
        long Id=long.Parse(Console.ReadLine());

        var existId=await this.patientService.CheckId(Id);
        if (existId==false)
        {
           // return MainPage();
        }

        Console.Write("Name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Surname: ");
        string LastName = Console.ReadLine();

        Console.Write("Phone number: ");
        string Phone = Console.ReadLine();

        Console.Write("Email: ");
        string Email = Console.ReadLine();

        Console.WriteLine("Address: ");
        string Address = Console.ReadLine();

        Console.Write("Date of birth: /yyyy.mm.dd/ ");
        DateTime DateOfBitrh = DateTime.Parse(Console.ReadLine());

        Console.Write("Gender: ");
        String Gender = Console.ReadLine();

        Patient patient = new Patient();
        patient.Id = Id;
        patient.DateOfBirth = DateOfBitrh;
        patient.FirstName = FirstName;
        patient.LastName = LastName;
        patient.Email = Email;
        patient.Phone = Phone;
        patient.Address = Address;
        patient.Gender = Gender;

        Console.WriteLine($" Id:{patient.Id} | Name:{patient.FirstName} | Surname: {patient.LastName} " +
                          $"| Phone number: {patient.Phone} | Email: {patient.Email} | Address: {patient.Address} " +
                          $"| Gender:{patient.Gender} | Data of birth: {patient.DateOfBirth} " +
                          $"| Registration time : {patient.UpdatedAt}");
    }
    public async void Delet()
    {
        Console.WriteLine("Enter your id: ");
        long Id = long.Parse(Console.ReadLine());
        var result=await this.patientService.RemoveAsync(Id);
        Console.WriteLine($"{result.ToString()}");
    }   
    public async void GetById()
    {
        Console.WriteLine("Enter your id: ");
        long Id = long.Parse(Console.ReadLine());
        var result=await this.patientService.GetByIdAsync(Id);
        Console.WriteLine($" Id:{result.Id} | Name:{result.FirstName} | Surname: {result.LastName} " +
                          $"| Phone number: {result.Phone} | Email: {result.Email} | Address: {result.Address} " +
                          $"| Gender:{result.Gender} | Data of birth: {result.DateOfBirth} ");
    }
    public async void GetAll()
    {
        
    }
    //public async void MedicalHistorySearch()
    //{
    //    Console.WriteLine("Enter your id: ");
    //    long patientId = long.Parse(Console.ReadLine());
    //    var result=await this.MedicalHistoryService.MedicalHistotySearch(patientId);
    //    Console.WriteLine($" Id:{result.} | Name:{result.FirstName} | Surname: {result.LastName} " +
    //                      $"| Phone number: {result.Phone} | Email: {result.Email} | Address: {result.Address} " +
    //                      $"| Gender:{result.Gender} | Data of birth: {result.DateOfBirth} ");
    //}
}
