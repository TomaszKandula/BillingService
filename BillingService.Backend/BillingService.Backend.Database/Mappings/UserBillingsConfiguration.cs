namespace BillingService.Backend.Database.Mappings;

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

[ExcludeFromCodeCoverage]
public class UserBillingsConfiguration : IEntityTypeConfiguration<UserBillings>
{
    public void Configure(EntityTypeBuilder<UserBillings> builder)
    {
        builder.Property(userBillings => userBillings.Id).ValueGeneratedOnAdd();

        builder
            .HasOne(userBillings => userBillings.Users)
            .WithMany(users => users.UserBillings)
            .HasForeignKey(userBillings => userBillings.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserBillings_Users");
    }
}