namespace InnoClinic.SharedModels.DTOs.Appointments.RequestParameters;

public class ScheduleParameters
{
    public Guid PatientId { get; set; }
    public int? Day { get; set; }
    public int? Month { get; set; }
    public int? Year { get; set; }
}
