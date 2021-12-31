namespace BillingService.Backend.Domain.Entities;

using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[ExcludeFromCodeCoverage]
public class ChargeTypes : Entity<Guid>
{
    [Required]
    [MaxLength(50)]
    public string TypeName { get; set; }    

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    [MaxLength(3)]
    public string CurrencyIso { get; set; }
}