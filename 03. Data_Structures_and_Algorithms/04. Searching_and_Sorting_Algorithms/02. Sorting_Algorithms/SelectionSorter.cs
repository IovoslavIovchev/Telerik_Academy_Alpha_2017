namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public IList<T> Sort(IList<T> collection)
        {
            T[] array = collection.ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min]) < 0)
                    {
                        min = j;
                    }
                }

                T temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            return array.ToList();
        }
    }
}
