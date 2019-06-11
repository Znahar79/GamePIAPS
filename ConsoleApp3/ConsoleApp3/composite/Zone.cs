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
        private BossShip boss;
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
            if (c.GetType() == typeof(BossShip))
            {
                boss = (BossShip)c;

            }
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

       

        public override void Remove(Component c)
        {
            if (c.GetType() == typeof(PirateShip))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                pirate = null;
                Console.WriteLine("Уничтожен пират");
                Console.ResetColor();
            }
            if (c.GetType() == typeof(AsteroidField))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                asteroid_field = null;
                Console.WriteLine("Уничтожены астероиды");
                Console.ResetColor();
            }
            if (c.GetType() == typeof(MainShip))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                player_ship = null;
                Console.WriteLine("Уничтожен игрок - конец игры!");
                Console.ResetColor();

            }
            if (c.GetType() == typeof(BossShip))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                boss = null;
                Console.WriteLine("Уничтожен босс - переход на новый уровень!");
                Console.ResetColor();
            }
        }
    }
}
