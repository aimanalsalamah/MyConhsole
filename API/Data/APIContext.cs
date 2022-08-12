using Microsoft.EntityFrameworkCore;
using Tools.Model;

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

        public DbSet<Tools.Model.Following>? Following { get; set; }

    }
}
