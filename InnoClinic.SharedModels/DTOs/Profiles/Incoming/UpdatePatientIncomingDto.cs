namespace InnoClinic.SharedModels.DTOs.Profiles.Incoming;

public class UpdatePatientIncomingDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
}
