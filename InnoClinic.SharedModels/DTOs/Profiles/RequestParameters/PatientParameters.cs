namespace InnoClinic.SharedModels.DTOs.Profiles.RequestParameters;

public class PatientParameters : PaginationParameters
{
    public string? FirstNameSearch { get; set; }
    public string? LastNameSearch { get; set; }
    public string? MiddleNameSearch { get; set; }
}
