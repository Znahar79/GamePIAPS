using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.composite
{
    class Zone : Component
    {
        private PirateShip pirate;
        private AsteroidField asteroid_field;
        private MainShip player_ship;
        public Zone(String name) : base(name) { }
        public override void Add(Component c)
        {
            if (c.GetType() == typeof(PirateShip))
            {
                pirate = (PirateShip)c;
            }
            if (c.GetType() == typeof(AsteroidField))
            {
                asteroid_field = (AsteroidField)c;
            }
            if(c.GetType() == typeof(MainShip))
            {
                player_ship = (MainShip)c;
               
            }
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

       

        public override void Remove(Component c)
        {
           
        }
    }
}
