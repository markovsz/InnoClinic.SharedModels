namespace InnoClinic.SharedModels.DTOs.Offices.Incoming.Queries;

public class GetOfficeByIdModel
{
    public Guid Id { get; set; }
    public GetOfficeByIdModel(Guid id)
    {
        Id = id;
    }
}
