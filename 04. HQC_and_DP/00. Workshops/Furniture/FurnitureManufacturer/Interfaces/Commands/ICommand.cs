using System.Collections.Generic;

namespace FurnitureManufacturer.Interfaces.Commands
{
    public interface ICommand
    {
        void Execute(IList<string> args);
    }
}
