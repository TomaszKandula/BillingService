namespace BillingService.Backend.Domain.Entities;

using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Enums;

[ExcludeFromCodeCoverage]
public class UserBillings : Entity<Guid>
{
    public Guid UserId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    [MaxLength(3)]
    public string CurrencyIso { get; set; }

    [Required]
    public DateTime ValueDate { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public bool IsInvoiceRequested { get; set; }

    [Required]
    public bool IsPaymentRequested { get; set; }

    [Required]
    public PaymentStatuses Status { get; set; }

    public Users Users { get; set; }
}