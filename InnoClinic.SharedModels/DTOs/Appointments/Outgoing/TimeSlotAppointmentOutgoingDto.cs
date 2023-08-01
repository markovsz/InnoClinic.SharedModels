namespace InnoClinic.SharedModels.DTOs.Appointments.Outgoing;

public class TimeSlotAppointmentOutgoingDto
{
    public DateTime DateTime { get; set; }
    public Guid ServiceId { get; set; }
}
