namespace InnoClinic.SharedModels.DTOs.Profiles.Incoming;

public class UpdateReceptionistIncomingDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public Guid OfficeId { get; set; }
}
