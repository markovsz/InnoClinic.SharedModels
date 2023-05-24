namespace InnoClinic.SharedModels.DTOs.Profiles.RequestParameters;

public class DoctorParameters : PaginationParameters
{
    public string? FirstNameSearch { get; set; }
    public string? LastNameSearch { get; set; }
    public string? MiddleNameSearch { get; set; }
    public Guid? SpecializationId { get; set; }
    public Guid? OfficeId { get; set; }
}
