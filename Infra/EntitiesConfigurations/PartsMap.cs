using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class PartsMap : IEntityTypeConfiguration<Parts>
    {
        public void Configure(EntityTypeBuilder<Parts> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired();

            builder.Property(b => b.Value)
                .IsRequired();
        }
    }
}