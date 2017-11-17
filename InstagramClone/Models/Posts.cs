using System;
using System.Collections.Generic;

namespace InstagramClone.Models
{
    public partial class Posts
    {
        public Posts()
        {
            Comments = new HashSet<Comments>();
            Likes = new HashSet<Likes>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public DateTime DatPosted { get; set; }
        public int? LikeCount { get; set; }
        public int? CommentCount { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Likes> Likes { get; set; }
    }
}
