using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Implementation
{
    public class Queue<T>
    {
        private int head;
        private int tail;
        private List<T> collection;

        public Queue()
        {
            this.head = 0;
            this.tail = -1;
            this.collection = new List<T>();
        }

        public void Enqueue(T item)
        {
            this.collection.Add(item);
            tail++;
        }

        public T Dequeue()
        {
            T temp = this.collection[head];
            this.collection.RemoveAt(head);

            return temp;
        }

        public T Peek()
        {
            return this.collection[head];
        }
    }
}
