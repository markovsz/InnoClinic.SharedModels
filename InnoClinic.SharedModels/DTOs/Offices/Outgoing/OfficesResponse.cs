namespace InnoClinic.SharedModels.DTOs.Offices.Outgoing;

public class OfficesResponse
{
    public IEnumerable<OfficeAddressResponse> Offices { get; set; }
    public int PagesCount { get; set; }
}
