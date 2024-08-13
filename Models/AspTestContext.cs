using Microsoft.EntityFrameworkCore;

namespace _20240722_AspNetCoreDB.Models
{
    public class AspTestContext: DbContext
    {
        public AspTestContext(DbContextOptions <AspTestContext> options): base(options) { }

        public DbSet<Note>? notes { get; set; } = null;
    }
}
