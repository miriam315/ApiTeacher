using Microsoft.EntityFrameworkCore;
using School.Core.Entities;

namespace School
{
    public class DataContext : DbContext
    {
        public DbSet<Teachers> teachers { get; set; }
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=School");
        }
    }
}
