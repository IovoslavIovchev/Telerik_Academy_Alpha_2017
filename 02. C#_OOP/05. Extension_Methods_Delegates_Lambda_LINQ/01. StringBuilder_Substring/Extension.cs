using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder_Substring
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            StringBuilder result = new StringBuilder();

            string temp = input.ToString();

            for (int i = index; i < temp.Length; i++)
            {
                result.Append(temp[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            string temp = input.ToString();

            for (int i = index; i < index + length; i++)
            {
                result.Append(temp[i]);
            }

            return result;
        }
    }
}
