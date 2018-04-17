using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Social_Network.Models
{
    public class Post
    {
        public Post()
        {
            this.TaggedUsers = new HashSet<UserProfile>();
        }

        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Content { get; set; }
        
        public DateTime PostedOn { get; set; }

        public virtual ICollection<UserProfile> TaggedUsers { get; set; }
    }
}
