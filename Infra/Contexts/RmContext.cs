﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts
{
    public class RmContext : DbContext
    {
        public RmContext(DbContextOptions<RmContext> options) : base(options)
        {
        }

        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RmContext).Assembly);
        }
    }
}