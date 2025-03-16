using Microsoft.EntityFrameworkCore;
using SlavicMyths.Models;

namespace SlavicMyths.Data
{
    public class SlavicMythologyDbContext : DbContext
    {
        public SlavicMythologyDbContext(DbContextOptions<SlavicMythologyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phenomenon> Phenomena { get; set; }
        public DbSet<Section> Sections { get; set; }


    }
}