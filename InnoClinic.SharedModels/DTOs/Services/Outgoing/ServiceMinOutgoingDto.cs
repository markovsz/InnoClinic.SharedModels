namespace InnoClinic.SharedModels.DTOs.Services.Outgoing;

public class ServiceMinOutgoingDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ServiceCategoryOutgoingDto Category { get; set; }
    public string Status { get; set; }
}
