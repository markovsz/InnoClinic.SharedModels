namespace InnoClinic.SharedModels.DTOs.Services.Incoming;

public class SpecializationIncomingDto
{
    public string Name { get; set; }
    public string Status { get; set; }
    public IEnumerable<ServiceIncomingDto> Services { get; set; }
}