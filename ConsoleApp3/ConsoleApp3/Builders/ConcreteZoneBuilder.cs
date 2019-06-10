using ConsoleApp3.composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Builders
{
    class ConcreteZoneBuilder:ZoneBuilder
    {
        public override Component CreateShip()
        {
            throw new NotImplementedException();
        }

        public override Zone CreateZone()
        {
            Console.WriteLine("Процесс создания зоны начат");
            PirateShipBuilder builder = new PirateShipBuilder();
            obj = new Zone("Зона");
            obj.Add(builder.CreateShip());
            Console.WriteLine("Процесс создания зоны закончен");
            return (Zone)obj;
        }        
    }
}
