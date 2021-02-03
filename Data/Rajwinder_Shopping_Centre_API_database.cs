using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rajwinder_Shopping_Centre_API.Modals;

namespace Rajwinder_Shopping_Centre_API.Data
{
    public class Rajwinder_Shopping_Centre_API_database : DbContext
    {
        public Rajwinder_Shopping_Centre_API_database (DbContextOptions<Rajwinder_Shopping_Centre_API_database> options)
            : base(options)
        {
        }

        public DbSet<Rajwinder_Shopping_Centre_API.Modals.Product> Product { get; set; }
    }
}
