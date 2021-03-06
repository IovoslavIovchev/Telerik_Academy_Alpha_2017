﻿using FurnitureManufacturer.Engine.Common;

namespace FurnitureManufacturer.Interfaces
{
    public interface IFurniture
    {
        string Model { get; }

        MaterialType Material { get; }

        decimal Price { get; }

        decimal Height { get; }

        string ToString();
    }
}
