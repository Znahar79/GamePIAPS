using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Builders
{
    class MainShipBuilder : ZoneBuilder
    {
        public override Component CreateShip()
       {
            obj = new MainShip("Игрок");
            for(int i = 0; i < 2; i++)
            {
                CrewMember new_mem = new CrewMember("Компаньон" + i);
                obj.Add(new_mem);                
            }
            Gear weapon = new Gear("Бластер I");
            obj.Add(weapon);
            obj.SetProc_of_wining(100);
            Console.WriteLine("Создался корабль игрока");            
            return obj;
        }

    }
}
