using Microsoft.EntityFrameworkCore;

namespace tutorial1.Models
{
    public class YourContext: DbContext
    {
        public YourContext(DbContextOptions<YourContext> options) : base(options)
         { }
        public DbSet<Quote> Quotes {get; set;}
    }
}