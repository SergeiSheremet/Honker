using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Honker.Models;
using Microsoft.EntityFrameworkCore;

namespace Honker.DataAccess
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Honk> Honks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
