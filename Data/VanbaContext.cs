using Microsoft.EntityFrameworkCore;

namespace VanbaApp.Data
{
    public class VanbaContext : DbContext
    {
        public VanbaContext (
            DbContextOptions<VanbaContext> options)
            : base(options)
        {
        }

        public DbSet<VanbaApp.Models.Word> Word { get; set; }
    }
}