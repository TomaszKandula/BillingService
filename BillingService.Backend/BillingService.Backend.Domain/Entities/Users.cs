namespace BillingService.Backend.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

[ExcludeFromCodeCoverage]
public class Users : Entity<Guid>
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(5)]
    public string UserAlias { get; set; }

    [Required]
    [MaxLength(255)]
    public string EmailAddress { get; set; }

    public bool IsActivated { get; set; }

    public DateTime Registered { get; set; }
        
    [Required]
    [MaxLength(100)]
    public string PrivateKey { get; set; }

    public ICollection<UserDetails> UserDetails { get; set; } = new HashSet<UserDetails>();

    public ICollection<UserDomains> UserDomains { get; set; } = new HashSet<UserDomains>();

    public ICollection<UserCharges> UserCharges { get; set; } = new HashSet<UserCharges>();

    public ICollection<UserBillings> UserBillings { get; set; } = new HashSet<UserBillings>();
}