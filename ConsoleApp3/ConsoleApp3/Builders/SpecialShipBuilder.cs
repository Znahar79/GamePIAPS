using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Builders
{
    class SpecialShipBuilder:ZoneBuilder
    {
        public override Component CreateShip()
        {
            obj = new BossShip("Босс");
            for (int i = 0; i < 2; i++)
            {
                CrewMember new_mem = new CrewMember("Компаньон" + i);
                obj.Add(new_mem);
            }
            Gear weapon = new Gear("Бластер I");
            obj.Add(weapon);
            obj.SetProc_of_wining(70);
            Console.WriteLine("Создался босс");
            return obj;
        }
        
    }
}
