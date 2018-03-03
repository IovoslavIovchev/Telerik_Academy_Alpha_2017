using Autofac;
using FurnitureManufacturer.Commands.CompanyCommands;
using FurnitureManufacturer.Commands.CreationalCommands;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Database;
using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;

namespace FurnitureManufacturer.NewClient.Injection
{
    public class ModuleConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyFactory>().As<ICompanyFactory>().SingleInstance();
            builder.RegisterType<FurnitureFactory>().As<IFurnitureFactory>().SingleInstance();
            builder.RegisterType<Database>().As<IDatabase>().SingleInstance();
            builder.RegisterType<ConsoleRenderer>().As<IRenderer>().SingleInstance();
            builder.RegisterType<Constants>().AsSelf().SingleInstance();
            builder.RegisterType<FurnitureEngine>().As<IEngine>().SingleInstance();
            builder.RegisterType<CommandParser>().As<ICommandParser>().SingleInstance();

            builder.RegisterType<AddFurnitureToCompanyCommand>().Named<ICommand>("addfurnituretocompany")           /*.SingleInstance()*/;
            builder.RegisterType<FindFurnitureFromCompanyCommand>().Named<ICommand>("findfurniturefromcompany")     /*.SingleInstance()*/;
            builder.RegisterType<RemoveFurnitureFromCompanyCommand>().Named<ICommand>("removefurniturefromcompany") /*.SingleInstance()*/;
            builder.RegisterType<ShowCompanyCatalogCommand>().Named<ICommand>("showcompanycatalog")                 /*.SingleInstance()*/;
            builder.RegisterType<CreateChairCommand>().Named<ICommand>("createchair")                               /*.SingleInstance()*/;
            builder.RegisterType<CreateCompanyCommand>().Named<ICommand>("createcompany")                           /*.SingleInstance()*/;
            builder.RegisterType<CreateTableCommand>().Named<ICommand>("createtable")                               /*.SingleInstance()*/;
        }
    }
}
