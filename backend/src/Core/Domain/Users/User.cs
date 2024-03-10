// Users/User.cs
// TODO: Define the User entity with necessary properties like Id, Name, Email, etc.

using System;
using System.Collections.Generic;

namespace VitaSync.Core.Domain.Users
{
    public class User
    {
        // Unique Identifier
        public Guid Id { get; set; }
            
        // Personal Details
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        // Profile Picture
        public string ProfilePicture { get; set; }

        // Authentication Details
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Contact Details
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        
        // Emergency Contact Details
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }

        // List Collection for roles and scopes if applicable
        public List<string> Roles { get; set; } = new List<string>();
        public List<string> Scopes { get; set; } = new List<string>();
        
        // Audit Details
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Status Details
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
    }

    // Defines the default and parameterised constructors for the User entity
    public User()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    
    // Parameterised constructor which calls the default constructor and sets the Name, Email and PasswordHash properties
    public User(string name, string email, string passwordHash, bool isVerified = false) : this()
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash; 
        IsVerified = IsVerified;
        
    }
    
    
    
    
}

