using System;
using Autofac;
using System.Reflection;
using OlympicGames.Core.Contracts;

namespace OlympicGames.StartUp.ModuleConfig
{
    public class ModuleConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(IEngine)))
                .AsImplementedInterfaces()
                .SingleInstance();

           // builder.RegisterType<ContainerBuilder>().SingleInstance();
        }
    }
}
