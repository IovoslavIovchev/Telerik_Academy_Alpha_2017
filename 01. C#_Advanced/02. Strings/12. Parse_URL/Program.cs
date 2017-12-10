using System;
using System.Text.RegularExpressions;

namespace Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            int serverIndex = url.IndexOf("://", 0);
            int resourceIndex = url.IndexOf("/", serverIndex + 3);

            string protocol = url.Substring(0, serverIndex);
            string server = url.Substring(serverIndex + 3, resourceIndex - serverIndex - 3);
            string resource = url.Substring(resourceIndex);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
