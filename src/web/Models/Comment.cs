using System;

namespace RssFeed.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CommentDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
    }
}