using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-IAA43F8R;Database=CoreBlogDb;Integrated Security=True");
        }
    }
}