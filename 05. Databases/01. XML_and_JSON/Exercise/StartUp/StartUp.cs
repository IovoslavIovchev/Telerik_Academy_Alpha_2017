using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace StartUp
{
    class Program
    {
        static void Main()
        {
            // XML
            XmlElement rootElement = LoadXML();

            PrintXMLAttributes(rootElement);

            // JSON
            IList<Movie> movies = LoadJSON();

            IList<string> orderedActors = movies
                .SelectMany(x => x.Actors)
                .OrderBy(y => y)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, orderedActors));
        }

        private static void PrintXMLAttributes(XmlElement element)
        {
            foreach (XmlNode node in element.ChildNodes)
            {
                foreach (XmlNode innerNode in node.ChildNodes)
                {
                    Console.WriteLine(innerNode.Name + " " + innerNode.InnerText);
                }
                Console.WriteLine();
            }
        }

        private static XmlElement LoadXML()
        {
            XmlDocument document = new XmlDocument();
            document.Load("./Resources/shiporders.xml");

            return document.DocumentElement;
        }

        private static IList<Movie> LoadJSON()
        {
            string jsonMovies = File.ReadAllText("./Resources/movies.json");

            return JsonConvert.DeserializeObject<List<Movie>>(jsonMovies);
        }
    }
}