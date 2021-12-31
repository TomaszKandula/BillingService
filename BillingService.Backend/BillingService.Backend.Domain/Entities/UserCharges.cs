namespace BillingService.Backend.Domain.Entities;

using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Enums;

[ExcludeFromCodeCoverage]
public class UserCharges : Entity<Guid>
{
    public Guid UserId { get; set; }

    public Guid ChargeTypeId { get; set; }

    [Required]
    public PaymentTerms Terms { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? Discount { get; set; }

    public DateTime? DiscountMaturity { get; set; }

    public Users Users { get; set; }

    public ChargeTypes ChargeTypes { get; set; }
}