﻿using System.Text.Json.Serialization;

namespace AutoYa_Backend.Security.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
    [JsonIgnore]
    public string PasswordHash { get; set; }
}