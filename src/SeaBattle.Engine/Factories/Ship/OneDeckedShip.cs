using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Factories.Ship
{
    class OneDeckedShip : Ship
    {
        OneDeckedShip() : base()
        {
            type = ShipType.OneDecked;
        }
    }
}
