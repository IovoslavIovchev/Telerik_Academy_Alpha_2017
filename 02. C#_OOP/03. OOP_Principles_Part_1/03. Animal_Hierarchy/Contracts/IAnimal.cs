using System;
using System.Collections.Generic;
using System.Text;
using Animal_Hierarchy.Common;

namespace Animal_Hierarchy.Contracts
{
    interface IAnimal
    {
        AnimalType Type { get; }

        string Name { get; }

        uint Age { get; }

        Sex Sex { get; }
    }
}
