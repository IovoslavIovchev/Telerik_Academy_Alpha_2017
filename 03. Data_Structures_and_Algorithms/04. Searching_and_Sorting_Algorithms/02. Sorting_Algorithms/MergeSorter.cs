namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private static T[] aux;

        public IList<T> Sort(IList<T> collection)
        {
            T[] array = collection.ToArray();
            aux = new T[array.Length];

            Sort(array, 0, array.Length - 1);

            return array.ToList();
        }

        private void Sort(T[] array, int low, int high)
        {
            if (high <= low) return;

            int mid = low + (high - low) / 2;

            Sort(array, low, mid);
            Sort(array, mid + 1, high);
            Merge(array, low, mid, high);
        }

        private void Merge(T[] array, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                aux[k] = array[k];
            }

            for (int t = low; t <= high; t++)
            {
                if (i > mid) array[t] = aux[j++];
                else if (j > high) array[t] = aux[i++];
                else if (aux[i].CompareTo(aux[j]) < 0) array[t] = aux[i++];
                else array[t] = aux[j++];
            }
        }
    }
}
