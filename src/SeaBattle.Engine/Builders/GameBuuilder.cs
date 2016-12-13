using SeaBattle.Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Builders
{
    public class GameBuuilder
    {
        public static Game Build()
        {
            return new Game();
        }
    }
}
