namespace SearchingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        public void Insert(int index, T item)
        {
            this.items.Insert(index, item);
        }

        public void Sort(ISorter<T> sorter)
        {
            this.items = sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            if (!this.items[0].Equals(this.items[1]))
            {
                Sort(new NoobSorter<T>());
            }

            return Search(item, items.ToArray(), 0, items.Count - 1);
        }

        private bool Search(T item, T[] array, int start, int end)
        {
            if ((end - start <= 1 && !array[start].Equals(item) && !array[end].Equals(item)) ||
                item.CompareTo(array[0]) < 0 || item.CompareTo(array[array.Length - 1]) > 0)
            {
                return false;
            }

            int mid = (start + end) / 2;

            if (item.Equals(array[mid]))
            {
                return true;
            }
            else if (item.CompareTo(array[mid]) < 0)
            {
                return Search(item, array, start, mid);
            }
            else
            {
                return Search(item, array, mid + 1, end);
            }
        }

        public void Shuffle()
        {
            //using the Fisher-Yates Shuffle Algorithm

            T[] array = this.items.ToArray();
            Random random = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = random.Next(i);

                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }

            this.items = new List<T>(array);
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
