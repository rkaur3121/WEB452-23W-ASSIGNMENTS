using Microsoft.EntityFrameworkCore;
using Magnets.Models;

namespace Magnets.Data
{
    public class MagnetContext : DbContext
    {
        public MagnetContext(DbContextOptions<MagnetContext> options)
            : base(options)
        {
        }

        public DbSet<Magnet> Movie { get; set; }
    }
}
