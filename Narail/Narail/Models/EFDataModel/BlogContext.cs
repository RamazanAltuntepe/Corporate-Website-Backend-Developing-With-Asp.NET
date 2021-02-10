using Microsoft.EntityFrameworkCore;

namespace Narail.Models.EFDataModel
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
