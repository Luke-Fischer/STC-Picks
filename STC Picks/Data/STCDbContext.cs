using Microsoft.EntityFrameworkCore;
using STC_Picks.Models;

namespace STC_Picks.Data
{
    public class STCDbContext : DbContext
    {
        public STCDbContext(DbContextOptions<STCDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users {get; set;}
    }
}
