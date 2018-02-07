using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerable_Extensions
{
    public static class Extensions
    {
        public static dynamic Sum<T>(this IEnumerable<T> collection) where T
            : struct, IComparable<T>, IConvertible
        {
            dynamic result = 0;

            foreach (T element in collection)
            {
                result += (dynamic)element;
            }

            return result;
        }

        public static dynamic Product<T>(this IEnumerable<T> collection) where T
            : struct, IComparable<T>, IConvertible
        {
            dynamic result = 0;

            foreach (T element in collection)
            {
                result *= (dynamic)element;
            }

            return result;
        }

        public static dynamic Min<T>(this IEnumerable<T> collection) where T
            : struct, IComparable<T>, IConvertible
        {
            dynamic result = collection.First();

            foreach (T element in collection)
            {
                if (element < result)
                {
                    result = element;
                }
            }

            return result;
        }

        public static dynamic Max<T>(this IEnumerable<T> collection) where T
            : struct, IComparable<T>, IConvertible
        {
            dynamic result = collection.First();

            foreach (T element in collection)
            {
                if (element > result)
                {
                    result = element;
                }
            }

            return result;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection) where T
            : struct, IComparable<T>, IConvertible
        {
            dynamic result = 0;

            foreach (T element in collection)
            {
                result += (dynamic)element;
            }

            return result / collection.Count();
        }
    }
}
