using System;
using System.Collections.Generic;

namespace InstagramClone.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCommented { get; set; }
        public string Content { get; set; }

        public Posts Post { get; set; }
        public Users User { get; set; }
    }
}
