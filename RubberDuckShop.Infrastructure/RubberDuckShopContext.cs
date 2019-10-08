using Microsoft.EntityFrameworkCore;
using RubberDuckShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Infrastructure
{
    public class RubberDuckShopContext : DbContext
    {
        public DbSet<RubberDuck> RubberDucks { get; set; }
        public DbSet<DuckColor> DuckColors { get; set; }
        public DbSet<DuckCostume> DuckCostumes { get; set; }
        public DbSet<DuckPattern> DuckPatterns { get; set; }
     
        public RubberDuckShopContext(DbContextOptions<RubberDuckShopContext> opt) : base(opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
