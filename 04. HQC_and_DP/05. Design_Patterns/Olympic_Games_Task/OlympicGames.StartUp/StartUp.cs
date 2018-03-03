using System;
using System.Reflection;
using Autofac;
using OlympicGames.Core.Contracts;

namespace OlympicGames.StartUp
{
    class StartUp
    {
        static void Main()
        {
            IEngine Engine = InitializeEngine();

            Engine.Run();
        }

        private static IEngine InitializeEngine()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            IEngine engine = builder.Build().Resolve<IEngine>();

            return engine;
        }
    }
}
