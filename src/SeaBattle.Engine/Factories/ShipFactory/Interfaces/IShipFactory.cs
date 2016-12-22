using SeaBattle.Engine.Factories.Ship;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Factories.ShipFactory.Interfaces
{
    interface IShipFactory
    {
        IShip Create();
    }
}
