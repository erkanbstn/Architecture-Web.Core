using Layers.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Layers.Repository.DataAccess
{
    public class AppDbContext : DbContext
    {
        // Context Constructor

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        // DbSets for Entities

        public DbSet<User> Users { get; set; }
    }
}
