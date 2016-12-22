namespace SeaBattle.Engine.Factories.Ship
{
    class Ship : IShip
    {
        public ShipType type { get; set; }
        public byte healthPoints { get; set; }

        public Ship()
        {
            healthPoints = (byte)type;
        }
    }
}
