namespace BillingService.Backend.Database.Mappings;

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

[ExcludeFromCodeCoverage]
public class ChargeTypesConfiguration : IEntityTypeConfiguration<ChargeTypes>
{
    public void Configure(EntityTypeBuilder<ChargeTypes> builder) 
        => builder.Property(chargeTypes => chargeTypes.Id).ValueGeneratedOnAdd();
}