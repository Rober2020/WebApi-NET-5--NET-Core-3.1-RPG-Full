using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character>  Characters { get; set; }
    }
}