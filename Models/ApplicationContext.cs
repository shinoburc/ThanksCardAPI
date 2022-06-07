#nullable disable
using Microsoft.EntityFrameworkCore;

namespace ThanksCardServer2.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Title> Titles { get; set; }    
        public DbSet<Template> Templates { get; set; }
        public DbSet<Midle>Midles { get; set; }
        public DbSet<Reply> Replys { get; set; }
        public DbSet<ThanksCard> ThanksCards { get; set; }
    }
}

