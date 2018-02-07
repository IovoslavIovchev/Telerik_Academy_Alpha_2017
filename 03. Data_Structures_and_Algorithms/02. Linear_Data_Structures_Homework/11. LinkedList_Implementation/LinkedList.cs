using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList_Implementation
{
    public class LinkedList<T>
    {
        private ListItem<T> first;
        private ListItem<T> last;
        private int count;

        public LinkedList()
        {
            this.first = null;
            this.last = null;
            this.count = 0;
        }

        public ListItem<T> First => this.first;

        public ListItem<T> Last => this.last;

        public int Count => this.count;

        public void AddFirst(T item)
        {
            ListItem<T> current = new ListItem<T>(item);
            if (this.first == null && this.last == null)
            {
                this.first = current;
                this.last = current;
                this.count++;
            }
            else
            {
                current.Next = this.first;
                this.first = current;
                this.count++;
            }
        }

        public void AddLast(T item)
        {
            ListItem<T> current = new ListItem<T>(item);
            this.last.Next = current;
            this.last = current;
        }
    }
}
