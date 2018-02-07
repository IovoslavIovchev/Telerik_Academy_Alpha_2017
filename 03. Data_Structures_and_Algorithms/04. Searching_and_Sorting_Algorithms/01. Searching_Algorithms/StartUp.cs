using SortingHomework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingHomework
{
    class StartUp
    {
        static void Main()
        {
            SortableCollection<int> collection = new SortableCollection<int>(new int[] { 3, 6, 8, 9, 11, 13, 76, 123, 12, -2 });

            collection.PrintAllItemsOnConsole();

            bool LinearSearchTrue = collection.LinearSearch(8);
            bool BinarySearchFalse = collection.BinarySearch(43);

            collection.Sort(new NoobSorter<int>());

            collection.PrintAllItemsOnConsole();
        }
    }
}
