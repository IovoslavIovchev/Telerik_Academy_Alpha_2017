using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHomework
{
    static class StartUp
    {
        static void Main()
        {
            SortableCollection<int> collection = new SortableCollection<int>(new int[] { 1, 4, 3, 7, 4, 2, 45, 123, 543, 8 });

            collection.Shuffle();

            collection.PrintAllItemsOnConsole();

            collection.Sort(new Sorter<int>());

            collection.PrintAllItemsOnConsole();

            collection.Shuffle();

            collection.PrintAllItemsOnConsole();

            bool binary = collection.BinarySearch(26, new Sorter<int>());

            Console.WriteLine(binary);
        }
    }
}
