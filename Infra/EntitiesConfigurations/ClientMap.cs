using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BillingAddress)
                .IsRequired();

            builder.HasOne(b => b.People)
                .WithOne(b => b.Client)
                .HasForeignKey<Client>(b => b.PeopleId);
        }
    }
}