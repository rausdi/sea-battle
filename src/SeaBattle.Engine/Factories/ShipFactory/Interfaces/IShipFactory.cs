using SeaBattle.Engine.Factories.Ship;

namespace SeaBattle.Engine.Factories.ShipFactory.Interfaces
{
    interface IShipFactory
    {
        IShip Create();
    }
}
