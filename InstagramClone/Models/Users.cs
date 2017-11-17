using System;
using System.Collections.Generic;

namespace InstagramClone.Models
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Likes = new HashSet<Likes>();
            Posts = new HashSet<Posts>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }

        public ICollection<Comments> Comments { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}
