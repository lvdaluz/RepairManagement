using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BirthDate)
                .IsRequired();

            builder.Property(b => b.Cep)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(b => b.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(b => b.Logradouro)
                .IsRequired();

            builder.Property(b => b.Name)
                .IsRequired();
        }
    }
}