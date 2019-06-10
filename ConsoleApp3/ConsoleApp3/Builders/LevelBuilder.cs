using ConsoleApp3.composite;
using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Builders
{
    class LevelBuilder : ZoneBuilder
    {
        public override Component CreateShip()
        {
            throw new NotImplementedException();
        }
        public override Level CreateLevel()
        {
            Console.WriteLine("Процесс создания уровня начат");
            ConcreteZoneBuilder builder = new ConcreteZoneBuilder();
            Random rnd = new Random();
            obj = new Level("Уровень");
            int n = rnd.Next();
            for (int i = 0; i < n; i++)
            {
                obj.Add(builder.CreateZone());
            }
            Console.WriteLine("Процесс создания уровня закончен");
            return (Level)obj;
        }
    }
}
