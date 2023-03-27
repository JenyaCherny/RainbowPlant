using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowPlant.Models;

namespace RainbowPlant.Data
{
    public class RainbowPlantContext : DbContext //Single Responsibility Principle. This class is responsibel only for handling Plants Context.
    {
        public RainbowPlantContext (DbContextOptions<RainbowPlantContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowPlant.Models.Plant> Plant { get; set; } = default!;
    }
}
