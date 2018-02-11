using System;
using System.IO;
using System.Reflection;
using System.Text;
using Autofac;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;
using FurnitureManufacturer.NewClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurnitureManufacturerTests.IOTests
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

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetAssembly(typeof(StartUp)));

            IContainer container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();
            engine.Start();

            string expected = output.ReadToEnd().Trim();
            string actual = result.ToString().Trim();

            Assert.AreEqual(expected, actual);
        }
    }
}
