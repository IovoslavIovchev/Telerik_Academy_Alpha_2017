namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private IList<T> items;

        private static Random rnd = new Random();

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items => this.items;

        public void Sort(ISorter<T> sorter)
        {
            this.items = sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item, ISorter<T> sorter)
        {
            Sort(sorter);

            return Search(item, this.items.ToArray(), 0, this.items.Count) != -1;
        }

        static int Search(T numToSearch, T[] array, int start, int end)
        {

            if ((end - start <= 1 && !array[start].Equals(numToSearch) && !array[end].Equals(numToSearch)) ||
                numToSearch.CompareTo(array[0]) < 0 || numToSearch.CompareTo(array[array.Length - 1]) > 0)
            {
                return -1;
            }

            int mid = (start + end) / 2;

            if (numToSearch.Equals(array[mid]))
            {
                return mid;
            }
            else if (numToSearch.CompareTo(array[mid]) < 0)
            {
                return Search(numToSearch, array, start, mid);
            }
            else
            {
                return Search(numToSearch, array, mid + 1, end);
            }
        }

        public void Shuffle()
        {
            //using the Fisher-Yates shuffle algorithm with O(n) complexity
            int n = this.items.Count;
            while (n-- > 1)
            {
                int m = rnd.Next(n + 1);
                T temp = this.items[m];
                this.items[m] = this.items[n];
                this.items[n] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            Console.WriteLine(string.Join(" ", this.items));
        }
    }
}
