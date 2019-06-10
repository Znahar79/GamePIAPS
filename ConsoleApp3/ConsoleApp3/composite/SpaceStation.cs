using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.composite
{
    class SpaceStation : Component
    {
        List<CrewMember> crew_members = new List<CrewMember>();
        public SpaceStation(String name) : base(name) { }
        public override void Add(Component c)
        {
            throw new NotImplementedException();
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
