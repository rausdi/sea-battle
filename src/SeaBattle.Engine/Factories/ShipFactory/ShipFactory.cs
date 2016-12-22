using SeaBattle.Engine.Factories.Ship;
using SeaBattle.Engine.Factories.ShipFactory.Interfaces;

namespace SeaBattle.Engine.Factories.ShipFactory
{
    class ShipFactory<T> where T : IShipFactory
    {
        static IShip Create()
        {
            var t = default(T);
            return t.Create();
        }
    }
}
