﻿namespace SeaBattle.Engine.Factories.Ship
{
    interface IShip
    {
        ShipType type { get; set; }
        byte healthPoints { get; set; }
    }
}
