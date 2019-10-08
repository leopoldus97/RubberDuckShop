using Microsoft.EntityFrameworkCore;
using RubberDuckShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubberDuckShop.Infrastructure
{
    public class RubberDuckShopContext : DbContext
    {
        public RubberDuckShopContext(DbContextOptions<RubberDuckShopContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }

        public DbSet<RubberDuck> RubberDucks { get; set; }
        public DbSet<DuckColor> DuckColors { get; set; }
        public DbSet<DuckCostume> DuckCostumes { get; set; }
        public DbSet<DuckPattern> DuckPatterns { get; set; }
    }
}
