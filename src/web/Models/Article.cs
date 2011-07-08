using System;
using System.Collections.Generic;

namespace RssFeed.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsPublished { get; set; }
        public Author Author { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}