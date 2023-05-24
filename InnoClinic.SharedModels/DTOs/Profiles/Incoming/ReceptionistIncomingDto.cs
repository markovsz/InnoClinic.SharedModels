﻿namespace InnoClinic.SharedModels.DTOs.Profiles.Incoming;

public class ReceptionistIncomingDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string AccountId { get; set; }
    public Guid OfficeId { get; set; }
}