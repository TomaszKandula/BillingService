namespace BillingService.Backend.Database;

using System.Reflection;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

[ExcludeFromCodeCoverage]
public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public virtual DbSet<Users> Users { get; set; }

    public virtual DbSet<UserDetails> UserDetails { get; set; }

    public virtual DbSet<UserDomains> UserDomains { get; set; }

    public virtual DbSet<UserBillings> UserBillings { get; set; }

    public virtual DbSet<UserCharges> UserCharges { get; set; }

    public virtual DbSet<ChargeTypes> ChargeTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ApplyConfiguration(modelBuilder);
    }

    private static void ApplyConfiguration(ModelBuilder modelBuilder) 
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}