namespace InnoClinic.SharedModels.DTOs.Appointments.RequestParameters;

public class AppointmentParameters
{
    public string? DoctorFirstName { get; set; }
    public string? DoctorLastName { get; set; }
    public string? DoctorMiddleName { get; set; }
    public Guid? ServiceId { get; set; }
    public bool? IsApproved { get; set; }
    public Guid? OfficeId { get; set; }
    public DateTime? DateTime { get; set; }
}
