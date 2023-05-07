namespace InnoClinic.SharedModels.DTOs.Identity.Incoming;

public class AccountIncomingDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ReEnteredPassword { get; set; }
}
