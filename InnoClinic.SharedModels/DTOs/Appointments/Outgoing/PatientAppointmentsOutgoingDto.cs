namespace InnoClinic.SharedModels.DTOs.Appointments.Outgoing;

public class PatientAppointmentsOutgoingDto
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public Guid DoctorId { get; set; }
    public string DoctorFirstName { get; set; }
    public string DoctorLastName { get; set; }
    public string DoctorMiddleName { get; set; }
    public string ServiceName { get; set; }
    public Guid? ResultId { get; set; }
}
