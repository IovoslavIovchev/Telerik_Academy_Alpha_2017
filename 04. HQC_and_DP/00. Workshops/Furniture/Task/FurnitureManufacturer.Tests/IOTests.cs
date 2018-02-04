using System;
using System.IO;
using FurnitureManufacturer.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurnitureManufacturer.Tests
{
    [TestClass]
    public class IOTests
    {
        [TestMethod]
        public void RunIOTest()
        {
            StreamReader input = new StreamReader($"./../../IOTests/001.in.txt");
            StreamReader output = new StreamReader($"./../../IOTests/001.out.txt");
            StringWriter result = new StringWriter();

            Console.SetIn(input);
            Console.SetOut(result);

            FurnitureManufacturerEngine.Instance.Start();

            string expected = output.ReadToEnd().Trim();
            string actual = result.ToString().Trim();

            Assert.AreEqual(expected, actual);
        }
    }
}
