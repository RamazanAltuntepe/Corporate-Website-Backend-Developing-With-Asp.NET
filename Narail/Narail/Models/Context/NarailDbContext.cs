using Microsoft.EntityFrameworkCore;
using Narail.Models.Entities;
using DbContext = System.Data.Entity.DbContext;

namespace Narail.Models.Context
{
    public class NarailDbContext : DbContext
    {
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MACBETH;Database=NarailDb");
        }
        public System.Data.Entity.DbSet<Blog> Blogs { get; set; }
    }
}
