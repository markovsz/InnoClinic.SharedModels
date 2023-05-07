namespace InnoClinic.SharedModels.Messages;

public class DoctorProfileUpdatedMessage
{
    public Guid Id { get; set; }
    public string DoctorFirstName { get; set; }
    public string DoctorLastName { get; set; }
    public string DoctorMiddleName { get; set; }
}
