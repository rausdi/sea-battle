using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Factories.Ship
{
    interface IShip
    {
        ShipType type { get; set; }
    }
}
