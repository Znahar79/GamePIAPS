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
       public static void Main(string[] args)
        {
            ZoneCreatorDir director = new ZoneCreatorDir();
            Level level;
            bool is_game_end = false;
            while(is_game_end == false)
            {
                level = director.CreateLevel();
                is_game_end = true;
            }
            Console.Read();
        }
        
    }
}
