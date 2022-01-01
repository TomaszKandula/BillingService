namespace BillingService.Backend.Database.Mappings;

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

[ExcludeFromCodeCoverage]
public class UserChargesConfiguration : IEntityTypeConfiguration<UserCharges>
{
    public void Configure(EntityTypeBuilder<UserCharges> builder)
    {
        builder.Property(userCharges => userCharges.Id).ValueGeneratedOnAdd();

        builder
            .HasOne(userCharges => userCharges.Users)
            .WithMany(users => users.UserCharges)
            .HasForeignKey(userCharges => userCharges.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserCharges_Users");

        builder
            .HasOne(userCharges => userCharges.ChargeTypes)
            .WithMany(chargeTypes => chargeTypes.UserCharges)
            .HasForeignKey(userCharges => userCharges.ChargeTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserCharges_ChargeTypes");
    }
}