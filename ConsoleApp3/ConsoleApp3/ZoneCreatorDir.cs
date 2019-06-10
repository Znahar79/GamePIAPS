using ConsoleApp3.Builders;
using ConsoleApp3.leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ZoneCreatorDir
    {
        public Level CreateLevel()
        {
           LevelBuilder builder = new LevelBuilder();
           return builder.CreateLevel();
        }
    }
}
