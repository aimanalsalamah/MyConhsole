using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tools.models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<Tools.models.Yaseer> Yaseer { get; set; } = default!;

        public DbSet<Tools.models.yazeed>? yazeed { get; set; }
    }
}
