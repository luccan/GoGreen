using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoGreen.Models;

namespace GoGreen.Data
{
    public class VegetableContext : DbContext
    {
        public VegetableContext (DbContextOptions<VegetableContext> options)
            : base(options)
        {
        }

        public DbSet<GoGreen.Models.Vegetable> Vegetable { get; set; }
    }
}
