using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattle.Engine.Models
{
    public class Game
    {
        private readonly Guid _id;

        public Guid ID { get { return _id; } }

        public Game()
        {
            _id = Guid.NewGuid();
        }

        public void Start()
        {
            
        }
    }
}
