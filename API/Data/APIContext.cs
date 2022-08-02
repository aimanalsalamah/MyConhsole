using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tools.Model;
using Tools.Models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<Tools.Model.Customer> Customer { get; set; } = default!;  

        public DbSet<Tools.Model.User>? User { get; set; }

        public DbSet<Tools.Models.Employers>? Employers { get; set; }
    }
}
