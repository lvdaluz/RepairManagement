using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Quantity)
                .IsRequired();

            builder.HasMany(b => b.Parts)
                .WithMany(b => b.Orders);

            builder.HasOne(b => b.Supplier)
                .WithMany(b => b.Orders)
                .HasForeignKey(b => b.SupplierId);
        }
    }
}