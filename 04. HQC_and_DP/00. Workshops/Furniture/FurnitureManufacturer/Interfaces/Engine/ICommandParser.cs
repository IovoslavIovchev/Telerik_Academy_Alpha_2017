using FurnitureManufacturer.Interfaces.Commands;

namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface ICommandParser
    {
        ICommand ParseCommand(string input);
    }
}
