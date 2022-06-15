using LoginPageReactNET.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPageReactNET.Configuration
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> Person { get; set; }
    }
}
