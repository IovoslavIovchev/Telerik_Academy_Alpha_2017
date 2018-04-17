using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            RegisteredOn = DateTime.Now;
            Images = new HashSet<Image>();
            Messages = new HashSet<Message>();
            Posts = new HashSet<Post>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        public DateTime RegisteredOn { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
