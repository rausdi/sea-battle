using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Factories.Ship
{
    class Ship : IShip
    {
        public ShipType type { get; set; }
    }
}
