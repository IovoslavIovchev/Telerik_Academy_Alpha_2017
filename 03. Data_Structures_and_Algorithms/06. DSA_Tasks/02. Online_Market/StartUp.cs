using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Market
{
    class StartUp
    {
        static Dictionary<string, SortedSet<Product>> productsByType;

        static SortedSet<Product> sortedProducts;

        static StringBuilder result;

        static void Main()
        {
            productsByType = new Dictionary<string, SortedSet<Product>>();
            sortedProducts = new SortedSet<Product>();
            result = new StringBuilder();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "end":
                        Console.Write(result);
                        return;
                    case "add":
                        Add(input);
                        break;
                    case "filter":
                        if (input[2] == "type") FilterByType(input);
                        else FilterByPrice(input);
                        break;
                }
            }
        }

        static void Add(string[] args)
        {
            Product toAdd = new Product(args[1], double.Parse(args[2]), args[3]);
            if (sortedProducts.Contains(toAdd))
            {
                result.AppendLine($"Error: Product {toAdd.Name} already exists");
                return;
            }
            if (!productsByType.ContainsKey(toAdd.Type))
            {
                productsByType.Add(toAdd.Type, new SortedSet<Product>() { toAdd });
            }
            else
            {
                productsByType[toAdd.Type].Add(toAdd);
            }

            sortedProducts.Add(toAdd);
            result.AppendLine($"Ok: Product {toAdd.Name} added successfully");
        }

        static void FilterByType(string[] args)
        {
            if (!productsByType.ContainsKey(args[3]))
            {
                result.AppendLine($"Error: Type {args[3]} does not exists");
                return;
            }

            result.Append("Ok: ");
            int c = 0;
            foreach (var item in productsByType[args[3]])
            {
                if (c > 9) break;
                result.Append($"{item}, ");
                c++;
            }
            result.Remove(result.Length - 2, 2);
            result.AppendLine();
        }

        static void FilterByPrice(string[] args)
        {
            double min = double.MinValue;
            double max = double.MaxValue;

            switch (args[3])
            {
                case "from":
                    min = double.Parse(args[4]);
                    max = args.Length == 7 ? double.Parse(args[6]) : max;
                    break;
                case "to":
                    max = double.Parse(args[4]);
                    break;
            }

            result.Append("Ok: ");
            bool cut = false;
            int c = 0;
            foreach (var item in sortedProducts)
            {
                if (c == 10) break;
                if (item.Price >= min && item.Price <= max)
                {
                    result.Append($"{item}, ");
                    cut = true;
                    c++;
                }
            }
            if (cut)
            {
                result.Remove(result.Length - 2, 2);
            }
            result.AppendLine();
        }
    }

    struct Product : IComparable<Product>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public Product(string name, double price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public int CompareTo(Product other)
        {
            int result = Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }
            if (result == 0)
            {
                result = Type.CompareTo(other.Type);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Name}({Price})";
        }
    }
}