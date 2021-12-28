using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restorant.Models;

namespace Restorant.Data
{
    public class RestorantContext : DbContext
    {
        public RestorantContext (DbContextOptions<RestorantContext> options)
            : base(options)
        {
        }

        public DbSet<Restorant.Models.Product> Product { get; set; }

        public DbSet<Restorant.Models.Category> Category { get; set; }
    }
}
