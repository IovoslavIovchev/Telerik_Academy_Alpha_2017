using System.Collections.Generic;

namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface IDatabase
    {
        IDictionary<string, ICompany> Companies { get; }

        IDictionary<string, IFurniture> Furnitures { get; }

        IList<string> TextLog { get; }

        void AddFurniture(IFurniture furniture);

        void AddCompany(ICompany company);

        void Log(string msg);
    }
}
