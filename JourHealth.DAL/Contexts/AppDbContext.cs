using JourHealth.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace JourHealth.DAL.Contexts;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string stringConnection = "Host=localhost;Port=5432;User Id=postgres;Database=Health; Password=abdualim2001;";
        optionsBuilder.UseNpgsql(stringConnection);
    }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<MedicalHistory> MedicalHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<MedicalHistory>()
        //    .HasOne(d => d.Patient)
        //    .WithMany()
        //    .HasForeignKey(d => d.PatienId);
        modelBuilder.Entity<Patient>().HasData(

               new Patient { Id = 1, FirstName = "Frasco", LastName = "Pargiter", DateOfBirth = new DateTimeOffset(new DateTime(1956, 06, 3)).UtcDateTime, Gender = "Male", Address = "2668 Garrison Court", Phone = "+7 722 471 0555", Email = "fpargiter0@addtoany.com" },
               new Patient { Id = 2, FirstName = "Urbanus", LastName = "Lunney", DateOfBirth = new DateTimeOffset(new DateTime(1978, 08, 23)).UtcDateTime, Gender = "Male", Address = "154 Lake View Hill", Phone = "+7 948 513 0995", Email = "ulunney1@mapy.cz" },
               new Patient { Id = 3, FirstName = "Wyndham", LastName = "Luckett", DateOfBirth = new DateTimeOffset(new DateTime(1988, 01, 12)).UtcDateTime, Gender = "Male", Address = "8 Kennedy Parkway", Phone = "+86 716 519 6428", Email = "wluckett2@zdnet.com" },
               new Patient { Id = 4, FirstName = "Zacharia", LastName = "Ferreiro", DateOfBirth = new DateTimeOffset(new DateTime(1928, 11, 01)).UtcDateTime, Gender = "Male", Address = "191 Del Sol Trail", Phone = "+62 556 355 0529", Email = "zferreiro3@plala.or.jp" },
               new Patient { Id = 5, FirstName = "Vannie", LastName = "Guare", DateOfBirth = new DateTimeOffset(new DateTime(2013, 04, 03)).UtcDateTime, Gender = "Female", Address = "62 Delladonna Crossing", Phone = "+62 433 615 2364", Email = "vguare4@blogspot.com" },
               new Patient { Id = 6, FirstName = "Dawn", LastName = "Drydale", DateOfBirth = new DateTimeOffset(new DateTime(2017, 09, 03)).UtcDateTime, Gender = "Female", Address = "90301 Jana Circle", Phone = "+63 433 896 1062", Email = "ddrydale5@psu.edu" },
               new Patient { Id = 7, FirstName = "Charil", LastName = "Selwyn", DateOfBirth = new DateTimeOffset(new DateTime(2021, 02, 04)).UtcDateTime, Gender = "Female", Address = "9244 6th Street", Phone = "+385 632 311 1550", Email = "cselwyn6@wufoo.com" },
               new Patient { Id = 8, FirstName = "Elijah", LastName = "Cordrey", DateOfBirth = new DateTimeOffset(new DateTime(1928, 06, 07)).UtcDateTime, Gender = "Male", Address = "78552 Mandrake Trail", Phone = "+380 203 655 7729", Email = "ecordrey7@adobe.com" },
               new Patient { Id = 9, FirstName = "Margo", LastName = "Drinkhill", DateOfBirth = new DateTimeOffset(new DateTime(2006, 06, 18)).UtcDateTime, Gender = "Female", Address = "3 Esch Terrace", Phone = "+20 625 506 6824", Email = "mdrinkhill8@telegraph.co.uk" },
               new Patient { Id = 10, FirstName = "Fair", LastName = "Saddleton", DateOfBirth = new DateTimeOffset(new DateTime(2009, 10, 09)).UtcDateTime, Gender = "Male", Address = "47 Buhler Pass", Phone = "+7 998 571 3542", Email = "fsaddleton9@wunderground.com" },
               new Patient { Id = 11, FirstName = "Osbourn", LastName = "Girodias", DateOfBirth = new DateTimeOffset(new DateTime(2013, 11, 18)).UtcDateTime, Gender = "Male", Address = "52813 Jenifer Plaza", Phone = "+7 509 569 5039", Email = "ogirodiasa@163.com" },
               new Patient { Id = 12, FirstName = "Freda", LastName = "Willatt", DateOfBirth = new DateTimeOffset(new DateTime(2001, 12, 12)).UtcDateTime, Gender = "Female", Address = "00220 Golf View Center", Phone = "+62 617 638 3707", Email = "fwillattb@epa.gov" },
               new Patient { Id = 13, FirstName = "Simone", LastName = "Kingzett", DateOfBirth = new DateTimeOffset(new DateTime(2001, 05, 18)).UtcDateTime, Gender = "Male", Address = "30 Waubesa Way", Phone = "+62 366 244 3294", Email = "skingzettc@gmpg.org" },
               new Patient { Id = 14, FirstName = "Timmy", LastName = "Kennelly", DateOfBirth = new DateTimeOffset(new DateTime(2003, 09, 17)).UtcDateTime, Gender = "Female", Address = "02 Hansons Center", Phone = "+595 118 401 2243", Email = "tkennellyd@mail.ru" },
               new Patient { Id = 15, FirstName = "Saxe", LastName = "Van Oord", DateOfBirth = new DateTimeOffset(new DateTime(2007, 07, 12)).UtcDateTime, Gender = "Male", Address = "8 Jackson Pass", Phone = "+380 700 958 2544", Email = "svanoorde@posterous.com" }
            );
        modelBuilder.Entity<MedicalHistory>().HasData(
            new MedicalHistory { Id = 1, DoctorSpeciality = "Dermatolog", DoctorFullName = "Cordrey Zacharia", Symptoms = "Measles", Diagnosis = "Asperger syndrome", TypeOfCure = "Diabetes Treatments", Recipe = "Aspiren,Izofluran", PatienId = 1, InspectionTime = new DateTimeOffset(new DateTime(2013, 02, 10)).UtcDateTime },
            new MedicalHistory { Id = 2, DoctorSpeciality = "Neurolog", DoctorFullName = "Drinkhill Elijah", Symptoms = "conjunctivitis", Diagnosis = " Rett syndrome", TypeOfCure = "Stem Cell Therapy", Recipe = "", PatienId = 2, InspectionTime = new DateTimeOffset(new DateTime(2018, 05, 15)).UtcDateTime },
            new MedicalHistory { Id = 3, DoctorSpeciality = "Orthoped", DoctorFullName = "Kennelly", Symptoms = "Cough", Diagnosis = " Scrotum", TypeOfCure = "Islet Cell Transplantation", Recipe = "", PatienId = 6, InspectionTime = new DateTimeOffset(new DateTime(2013, 09, 18)).UtcDateTime },
            new MedicalHistory { Id = 4, DoctorSpeciality = "Pediatr", DoctorFullName = "Lunney Freda", Symptoms = "Pathognomonic", Diagnosis = " Strabismus", TypeOfCure = "Immunotherapies", Recipe = "", PatienId = 1, InspectionTime = new DateTimeOffset(new DateTime(2007, 02, 20)).UtcDateTime },
            new MedicalHistory { Id = 5, DoctorSpeciality = "Cardiolog", DoctorFullName = "Ferreiro Timmy", Symptoms = "Dehydration", Diagnosis = "Reproductive system", TypeOfCure = "Inhaled Insulin", Recipe = "", PatienId = 1, InspectionTime = new DateTimeOffset(new DateTime(2017, 05, 23)).UtcDateTime },
            new MedicalHistory { Id = 6, DoctorSpeciality = "Psychiatr", DoctorFullName = "Kennelly Dawn", Symptoms = "Allergy", Diagnosis = " Pervasive developmental disorders ", TypeOfCure = "Preserve Function of Beta Cells", Recipe = "", PatienId = 3, InspectionTime = new DateTimeOffset(new DateTime(2001, 12, 11)).UtcDateTime }
            );

    }
}
