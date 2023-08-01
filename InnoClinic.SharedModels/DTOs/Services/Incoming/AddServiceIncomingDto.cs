﻿namespace InnoClinic.SharedModels.DTOs.Services.Incoming;

public class AddServiceIncomingDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public Guid SpecializationId { get; set; }
    public string Status { get; set; }
}