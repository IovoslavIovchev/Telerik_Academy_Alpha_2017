namespace Classes_Part_2
{
    using Bytes2you.Validation;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GenericList<T>
    {
        private T[] elements;
        private int c = 0;

        public GenericList()
        {
            this.elements = new T[4];
        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        private void AutoGrow(bool shrink = false)
        {
            if (shrink)
            {
                this.c--;
            }
            else
            {
                this.c++;
            }
            if (this.c == this.elements.Length)
            {
                T[] temp = new T[this.elements.Length * 2];
                for (int i = 0; i < this.elements.Length; i++)
                {
                    temp[i] = this.elements[i];
                }
                this.elements = temp;
            }
        }

        public int Count
        {
            get
            {
                return this.c;
            }
        }

        public void Add(T element)
        {
            if (element == null) throw new ArgumentNullException("Element can't be null");

            this.elements[c] = element;

            AutoGrow();
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[elements.Length - 1] = default(T);

            AutoGrow(true);
        }

        public void Insert(int index, T element)
        {
            AutoGrow();

            for (int i = this.elements.Length - 1; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
        }

        public void Clear()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                this.elements[i] = default(T);
            }
        }

        public T this[int index]
        {
            get
            {
                Guard.WhenArgument(index, "Index")
                    .IsGreaterThanOrEqual(elements.Length)
                    .Throw();

                return this.elements[index];
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.elements);
        }


    }
}
