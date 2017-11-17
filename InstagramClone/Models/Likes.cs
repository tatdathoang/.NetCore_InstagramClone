using System;
using System.Collections.Generic;

namespace InstagramClone.Models
{
    public partial class Likes
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        public Posts Post { get; set; }
        public Users User { get; set; }
    }
}
