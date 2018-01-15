namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            T[] array = collection.ToArray();

            Sort(array, 0, array.Length - 1);

            collection = array.ToList();
        }

        public void Sort(T[] array, int low, int high)
        {
            if (high <= low) return;

            while (low < high)
            {
                int j = Partition(array, low, high);

                if (j - low < high - j)
                {
                    Sort(array, low, j - 1);
                    low = j + 1;
                }
                else
                {
                    Sort(array, j + 1, high);
                    high = j - 1;
                }
            }
        }

        public static int Partition(T[] array, int low, int high)
        {
            int i = low;
            int j = high + 1;

            T pivot = array[low];

            while (true)
            {
                while (array[++i].CompareTo(pivot) < 0) if (i == high) break;

                while (pivot.CompareTo(array[--j]) < 0) if (j == low) break;

                if (j <= i) break;

                Swap(array, i, j);
            }

            Swap(array, low, j);
            return j;
        }

        private static void Swap(T[] array, int i, int j)
        {
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
