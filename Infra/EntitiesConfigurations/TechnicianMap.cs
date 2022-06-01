using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfigurations
{
    public class TechnicianMap : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.HiredIn)
                .IsRequired();

            builder.HasOne(b => b.People)
                .WithOne(p => p.Technician)
                .HasForeignKey<Technician>(b => b.PeopleId);
        }
    }
}