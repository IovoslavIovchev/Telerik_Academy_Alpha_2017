using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Implementation
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> next;

        public ListItem(T value)
        {
            this.value = value;
            this.next = null;
        }

        public T Value
        {
            get => this.value;

            set => this.value = value;
        }

        public ListItem<T> Next
        {
            get => this.next;

            set => this.next = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
