using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Implementation
{
    public class Stack<T>
    {
        private int top;
        private T[] collection;

        public Stack()
        {
            this.top = -1;
            this.collection = new T[4];
        }

        public Stack(int N)
        {
            this.top = -1;
            this.collection = new T[N];
        }

        public T Pop()
        {
            if (this.top < 0)
            {
                throw new ArgumentException("Stack is empty");
            }

            T temp = this.collection[top];
            this.collection[top--] = default(T);

            return temp;
        }

        public T Peek()
        {
            if (this.collection.Length == 0)
            {
                throw new ArgumentException("Stack is empty");
            }

            return this.collection[top];
        }

        public void Push(T item)
        {
            if (this.top + 1 >= this.collection.Length)
            {
                ResizeStack();
            }
            this.collection[++this.top] = item;
        }

        private void ResizeStack()
        {
            T[] newStack = new T[this.collection.Length * 2];

            Array.Copy(this.collection, newStack, this.top);

            this.collection = newStack;
        }
    }
}
