using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class BudgetMap : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BudgetDeliveryDeadline)
                .IsRequired();

            builder.Property(b => b.Finalized)
                .IsRequired();

            builder.Property(b => b.Product)
                .IsRequired();

            builder.HasOne(b => b.ProductType)
                .WithMany(b => b.Budgets)
                .HasForeignKey(b => b.ProductTypeId);

            builder.HasOne(b => b.Client)
                .WithMany(b => b.Budgets)
                .HasForeignKey(b => b.ClientId);

            builder.HasOne(b => b.TechnicianWhoCreated)
                .WithMany(b => b.Budgets)
                .HasForeignKey(b => b.CreatedBy);

            builder.HasOne(b => b.TechnicianWhoRepair)
                .WithMany(b => b.Repairs)
                .HasForeignKey(b => b.RepairBy);

            builder.HasMany(b => b.Parts)
                .WithMany(b => b.Budgets);
        }
    }
}