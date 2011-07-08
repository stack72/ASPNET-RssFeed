using System.Collections.Generic;
using System.Linq;

namespace RssFeed.Models
{
    public class RepositoryLayer: IRepositoryLayer
    {
        public List<Article> GetAll()
        {
            var articles = new List<Article>();
            using (var db = new BlogPosts())
            {
                articles = (from posts in db.Articles
                           select posts).ToList();
            }

            return articles;
        }
    }
}