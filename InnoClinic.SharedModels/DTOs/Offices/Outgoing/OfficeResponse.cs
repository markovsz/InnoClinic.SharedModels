﻿namespace InnoClinic.SharedModels.DTOs.Offices.Outgoing;

public class OfficeResponse
{
    public Guid Id { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string OfficeNumber { get; set; }
    public string RegistryPhoneNumber { get; set; }
    public string Status { get; set; }
}
