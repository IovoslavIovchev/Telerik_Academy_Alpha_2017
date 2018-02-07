namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class StartUp
    {
        internal static void Main()
        {
            Stopwatch sw = new Stopwatch();

            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("All items before sorting:");
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("SelectionSorter result:");
            sw.Start();
            collection.Sort(new SelectionSorter<int>());
            collection.PrintAllItemsOnConsole();
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds.ToString()}ms");
            Console.WriteLine();

            collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("Quicksorter result:");
            sw.Start();
            collection.Sort(new Quicksorter<int>());
            collection.PrintAllItemsOnConsole();
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds.ToString()}ms");
            Console.WriteLine();

            collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("MergeSorter result:");
            sw.Start();
            collection.Sort(new MergeSorter<int>());
            collection.PrintAllItemsOnConsole();
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds.ToString()}ms");
            Console.WriteLine();

            Console.WriteLine("Linear search 101:");
            Console.WriteLine(collection.LinearSearch(101));
            Console.WriteLine();

            Console.WriteLine("Binary search 101:");
            Console.WriteLine(collection.BinarySearch(101));
            Console.WriteLine();

            Console.WriteLine("Shuffle:");
            collection.Shuffle();
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("Shuffle again:");
            collection.Shuffle();
            collection.PrintAllItemsOnConsole();
        }
    }
}
