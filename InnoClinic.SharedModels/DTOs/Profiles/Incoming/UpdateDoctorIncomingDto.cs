using InnoClinic.SharedModels.DTOs.Documents.Incoming;

namespace InnoClinic.SharedModels.DTOs.Profiles.Incoming;

public class UpdateDoctorIncomingDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime BirthDate { get; set; }
    public Guid SpectializationId { get; set; }
    public Guid OfficeId { get; set; }
    public int CareerStartYear { get; set; }
    public string Status { get; set; }
}
