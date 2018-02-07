using System.Collections.Generic;

namespace FurnitureManufacturer.Interfaces.Commands
{
    public interface ICommand
    {
        string Execute(IList<string> args);
    }
}
