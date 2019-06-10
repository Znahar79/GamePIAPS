using ConsoleApp3.composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.leaf
{
    class Resource : Component
    {
        public Resource(String name) : base(name) { }
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
