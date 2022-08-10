using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<Tools.Model.Customr> Customr { get; set; } = default!;

        public DbSet<Tools.Model.record1>? record1 { get; set; }= default!;

    }
}
