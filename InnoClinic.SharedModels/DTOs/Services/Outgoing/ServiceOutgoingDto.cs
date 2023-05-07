namespace InnoClinic.SharedModels.DTOs.Services.Outgoing;

public class ServiceOutgoingDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; }
    public ServiceCategoryOutgoingDto Category { get; set; }
    public SpecializationMinOutgoingDto Specialization { get; set; }
    public string Status { get; set; }
}
