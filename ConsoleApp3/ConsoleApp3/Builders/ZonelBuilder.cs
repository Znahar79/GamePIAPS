using ConsoleApp3.composite;
using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class ZoneBuilder
    {
        protected Component obj;
        public abstract Component CreateShip();
        public virtual void CreateSpaceStation() { }
        public virtual void CreateAsteroidsField() { }
        public virtual Zone CreateZone() { return (Zone)obj; }
        //public virtual Zone GetZone() { return (Zone)obj;}
        public virtual Level CreateLevel() { return (Level)obj; }
        //public virtual Level GetLevel() { return (Level)obj; }
    }
}
