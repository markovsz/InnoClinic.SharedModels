using System.Runtime.Serialization;

namespace InnoClinic.SharedModels.DTOs.Offices.Incoming.Commands;

public class ChangeOfficeStatusModel
{
    [IgnoreDataMember]
    public Guid Id { get; set; }
    public string Status { get; set; }

    public ChangeOfficeStatusModel()
    {
    }

    public ChangeOfficeStatusModel(Guid id, string status)
    {
        Id = id;
        Status = status;
    }
}
