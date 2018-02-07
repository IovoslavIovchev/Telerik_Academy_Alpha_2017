using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingHomework
{
    public class NoobSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IList<T> Sort(IList<T> collection)
        {
            T[] array = collection.ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    min = array[i].CompareTo(array[j]) < 0 ? i : j;
                }

                if (min != i) Swap(array, i, min);
            }

            return array.ToList();
        }

        private static void Swap(T[] array, int i, int j)
        {
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
