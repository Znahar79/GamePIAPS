using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Builders
{
    class PirateShipBuilder : ZoneBuilder
    {
        public override Component CreateShip()
        {           
            obj = new BossShip("Пират");
            for (int i = 0; i < 2; i++)
            {
                CrewMember new_mem = new CrewMember("Компаньон" + i);
                obj.Add(new_mem);
            }
            Gear weapon = new Gear("Фазер I");
            obj.Add(weapon);
            obj.SetProc_of_wining(30);
            Console.WriteLine("Создался корабль пиратов");
            return obj;
        }
    }
}
