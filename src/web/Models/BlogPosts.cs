using System.Data.Entity;

namespace RssFeed.Models
{
    public class BlogPosts: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}