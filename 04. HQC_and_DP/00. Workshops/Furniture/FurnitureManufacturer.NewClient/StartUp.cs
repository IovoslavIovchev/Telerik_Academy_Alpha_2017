using Autofac;
using FurnitureManufacturer.Interfaces.Engine;
using System.Reflection;

namespace FurnitureManufacturer.NewClient
{   
    public class StartUp
    {
        static void Main()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            engine.Start();
        }
    }
}
