using System;
using System.Collections.Generic;

namespace Social_Network.Models
{
    public class Friendship
    {
        public Friendship()
        {
            this.Messages = new HashSet<Message>();
        }

        public int ID { get; set; }
        
        public int FirstUserID { get; set; }
        
        public int SecondUserID { get; set; }
        
        public bool Approved { get; set; }

        public DateTime? FriendsSince { get; set; }

        public virtual UserProfile FirstUser { get; set; }

        public virtual UserProfile SecondUser { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
