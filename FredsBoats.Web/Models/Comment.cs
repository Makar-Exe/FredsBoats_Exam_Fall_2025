using System;

namespace FredsBoats.Web.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int BoatId { get; set; }
        
        public Boat Boat { get; set; }
    }
}
