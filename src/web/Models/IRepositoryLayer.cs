using System.Collections.Generic;

namespace RssFeed.Models
{
    public interface IRepositoryLayer
    {
        List<Article> GetAll();
    }
}