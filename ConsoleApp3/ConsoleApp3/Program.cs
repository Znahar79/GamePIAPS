using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp3.leaf;
using ConsoleApp3.composite;

namespace ConsoleApp3
{
    class Program
    {
       public void Main(string[] args)
        {
            ZoneCreatorDir director = new ZoneCreatorDir();
            bool is_game_end = false;
            while(is_game_end == false)
            {
                director.CreateLevel();
            }
        }
        
    }
}
