namespace InnoClinic.SharedModels.DTOs.Appointments.RequestParameters;

public class TimeSlotParameters
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public Guid DoctorId { get; set; }
}
