using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WuzzyBears.Models;

namespace WuzzyBears.Data
{
    public class WuzzyBearContext : DbContext
    {
        public WuzzyBearContext(DbContextOptions<WuzzyBearContext> options)
            : base(options)
        {
        }

        public DbSet<WuzzyBear> WuzzyBear { get; set; }

    }
}
