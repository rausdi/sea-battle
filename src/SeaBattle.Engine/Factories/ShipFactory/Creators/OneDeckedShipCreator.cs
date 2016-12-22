using SeaBattle.Engine.Factories.Ship;
using SeaBattle.Engine.Factories.ShipFactory.Interfaces;

namespace SeaBattle.Engine.Factories.ShipFactory.Creators
{
    class OneDeckedShipCreator : IShipFactory
    {
        public IShip Create()
        {
            return new OneDeckedShip();
        }
    }
}
