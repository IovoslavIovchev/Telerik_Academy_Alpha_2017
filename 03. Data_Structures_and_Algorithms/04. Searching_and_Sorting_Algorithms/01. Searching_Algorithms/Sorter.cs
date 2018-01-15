using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHomework
{
    public class Sorter<T> : ISorter<T> where T : IComparable
    {
        public IList<T> Sort(IList<T> collection)
        {
            T[] temp = collection.ToArray();
            collection = InsertionSort(temp).ToList();

            return collection;
        }

        private T[] InsertionSort(T[] collection)
        {
            T[] sorted = new T[collection.Length];

            for (int i = 0; i < collection.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (sorted[j].CompareTo(collection[i]) == 1)
                    {
                        break;
                    }
                }

                for (int k = i; k > j; k--)
                {
                    sorted[k] = sorted[k - 1];
                }

                sorted[j] = collection[i];
            }

            return sorted;
        }
    }
}
