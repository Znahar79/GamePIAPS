using ConsoleApp3.composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.leaf
{
    class Level : Component
    {
        public List<Zone> zones = new List<Zone>();
        public Level(String name) : base(name) { }
        public override void Add(Component c)
        {
            if (c.GetType() == typeof(Zone))
            {
                zones.Add((Zone)c);
            }
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
