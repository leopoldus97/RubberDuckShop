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

        public DbSet<RubberDuck> rubberDucks { get; set; }
        public DbSet<DuckColor> duckColor { get; set; }
        public DbSet<DuckCostume> duckCostume { get; set; }
        public DbSet<DuckPattern> duckPattern { get; set; }
    }
}
