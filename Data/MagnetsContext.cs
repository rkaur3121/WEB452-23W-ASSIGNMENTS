using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Magnets.Models;

namespace Magnets.Data
{
    public class MagnetsContext : DbContext
    {
        public MagnetsContext (DbContextOptions<MagnetsContext> options)
            : base(options)
        {
        }

        public DbSet<Magnets.Models.Magnet> Magnet { get; set; }
    }
}
