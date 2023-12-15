using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext  //DbContext is a combination of the Unit Of Work and Repository patterns.
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        

        public DbSet<Activity> Activities { get; set; }
    }
}