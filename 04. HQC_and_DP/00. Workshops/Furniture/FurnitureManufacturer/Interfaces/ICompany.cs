using System.Collections.Generic;

namespace FurnitureManufacturer.Interfaces
{
    public interface ICompany
    {
        string Name { get; }

        string RegistrationNumber { get; }

        ICollection<IFurniture> Furnitures { get; }

        void AddFurniture(IFurniture furniture);

        void RemoveFurniture(IFurniture furniture);

        IFurniture FindFurniture(string model);

        string Catalog();
    }
}
