﻿namespace InnoClinic.SharedModels.DTOs.Appointments.Outgoing;

public class AppointmentScheduleByDoctorOutgoingDto
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public Guid PatientId { get; set; }
    public string DoctorFirstName { get; set; }
    public string DoctorLastName { get; set; }
    public string DoctorMiddleName { get; set; }
    public string ServiceName { get; set; }
    public Guid SpecializationId { get; set; }
    public bool IsApproved { get; set; }
    public Guid? ResultId { get; set; }
}
