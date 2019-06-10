using ConsoleApp3.composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.leaf
{
    class MainShip : Component
    {
        List<CrewMember> crew_members = new List<CrewMember>();
        private Zone cur_zone;
        public MainShip(String name) : base(name) { }
        public override void Add(Component c)
        {
            if (c.GetType() == typeof(Gear)){
                weapon = (Gear)c;
            }
            if (c.GetType() == typeof(CrewMember)){
                crew_members.Add((CrewMember)c);
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
