using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;
        private string author;

        public Comment(string content)
        {
            if (content == null)
                { throw new ArgumentNullException(); }
            if (content.Length < 3 || content.Length > 200)
                { throw new ArgumentException("Content must be between 3 and 200 characters long!"); }

            this.content = content;
        }

        public string Content => this.content;

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }

    }
}
