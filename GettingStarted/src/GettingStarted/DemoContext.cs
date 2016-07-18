using GettingStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace GettingStarted
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<Parent> Parent { get; set; }
        public DbSet<Child> Child { get; set; }
    }
}
