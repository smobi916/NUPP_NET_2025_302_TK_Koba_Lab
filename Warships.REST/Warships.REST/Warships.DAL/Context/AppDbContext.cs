using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Warships.BLL.Entities;

namespace Warships.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Warship> Warships => Set<Warship>();
    }
}
