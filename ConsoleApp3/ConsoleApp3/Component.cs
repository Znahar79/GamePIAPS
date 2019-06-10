using ConsoleApp3.composite;
using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Component
    {
        protected String name;
        protected float proc_of_wining;
        protected Gear weapon;
        public String GetName() { return name; }
        public void SetName(String name) { this.name = name; }
        public String GetWeapon() { return weapon.GetName(); }
        public void SetWeapon(Gear weapon) { this.weapon = weapon; }
        public float GetProc_of_wining() { return proc_of_wining; }
        public void SetProc_of_wining(float proc_of_wining) { this.proc_of_wining = proc_of_wining; }
        public Component(String name)
        {
            this.name = name;
        }
        
        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
       
    }
}
