using System;
using System.ComponentModel.DataAnnotations;

namespace Social_Network.Models
{
    public class Message
    {
        public int ID { get; set; }

        [Required]
        public int AuthorID { get; set; }

        [Required]
        public string Content { get; set; }
        
        public DateTime SentOn { get; set; }

        public DateTime? SeenOn { get; set; }

        public virtual UserProfile Author { get; set; }
    }
}
