using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrategyMack.Models;

namespace StrategyMack.Data
{
    public class StrategyMackContext : DbContext
    {
        public StrategyMackContext (DbContextOptions<StrategyMackContext> options)
            : base(options)
        {
        }

        public DbSet<StrategyMack.Models.Initiative> Initiative { get; set; } = default!;
        public DbSet<StrategyMack.Models.InitiativeAttribute> InitiativeAttribute { get; set; } = default!;
        public DbSet<StrategyMack.Models.AppUser> AppUser { get; set; } = default!;
        public DbSet<StrategyMack.Models.AttributeDetail> AttributeDetail { get; set; } = default!;
        public DbSet<StrategyMack.Models.AttributeDetailMultiple> AttributeDetailMultiple { get; set; } = default!;

    }
}
