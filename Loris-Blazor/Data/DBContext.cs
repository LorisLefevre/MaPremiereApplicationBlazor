using Microsoft.EntityFrameworkCore;
using Loris_Blazor.Models;

namespace Loris_Blazor.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> contextOptions) : base(contextOptions) 
        { 

        }

        public DbSet<User> Users { get; set; }
    }
}
