using System;
using System.IO;
using System.Text;
using FurnitureManufacturer.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurnitureManufacturerTests
{
    [TestClass]
    public class IOTests
    {
        [TestMethod]
        public void IOTest()
        {
            StreamReader input = new StreamReader("./../../Tests/in.txt");
            StreamReader output = new StreamReader("./../../Tests/out.txt");
            StringWriter result = new StringWriter();
            

            Console.SetIn(input);
            Console.SetOut(result);

           //FurnitureEngine engine = new FurnitureEngine();
           //engine.Start();

            string expected = output.ReadToEnd().Trim();
            string actual = result.ToString().Trim();

            //Assert.AreEqual(expected, actual);
        }
    }
}
