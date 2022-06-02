using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts
{
    public class RmContext : DbContext
    {
        public RmContext(DbContextOptions<RmContext> options) : base(options)
        {
        }

        public DbSet<People> People { get; set; }
        public DbSet<Technician> Technician { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RmContext).Assembly);
        }
    }
}