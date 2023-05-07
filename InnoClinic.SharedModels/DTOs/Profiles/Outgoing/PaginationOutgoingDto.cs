namespace InnoClinic.SharedModels.DTOs.Profiles.Outgoing;

public class PaginationOutgoingDto<TEntityOutgoingDto>
{
    public IEnumerable<TEntityOutgoingDto> Entities { get; set; }
    public int PagesCount { get; set; }
}
