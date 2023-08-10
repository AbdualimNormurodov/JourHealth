﻿using JourHealth.Domain.Commons;

namespace JourHealth.Domain.Entites;

public class Patient:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}
