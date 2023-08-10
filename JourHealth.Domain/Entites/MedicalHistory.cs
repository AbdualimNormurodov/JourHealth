using JourHealth.Domain.Commons;

namespace JourHealth.Domain.Entites;

public class MedicalHistory:Auditable
{
    public string DoctorSpeciality { get; set; }
    public string DoctorFullName { get; set; }
    public string Symptoms { get; set; }
    public string Diagnosis { get; set; }
    public string TypeOfCure { get; set; }
    public string Recipe { get; set; }
    public DateTime InspectionTime { get; set; }
    public long PatienId { get; set; }
    public Patient Patient { get; set; }
}
