using System.Collections.Generic;

namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface IRenderer
    {
        string Input();

        void Output(string output);

        void Output(IEnumerable<string> output);
    }
}
