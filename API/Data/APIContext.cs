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

        public DbSet<Tools.Model.Customers> Customers { get; set; } = default!;

        public DbSet<Tools.Model.Users>? Users { get; set; }
    }
}
