using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace ConsoleDungeon
{
    class Program
    {
        /*
        enum LocationObject
        {
            Path = 0,
            Player = 1,
            Terrain = 3,
            Enemy = 8
        }

        static LocationObject[,] location = new LocationObject[,] 
        {
            { LocationObject.Player, LocationObject.Path, LocationObject.Enemy },
            { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path },
            { LocationObject.Path, LocationObject.Path, LocationObject.Path },
        };

        static string[,] locationStr = new string[,]
        {
            { "@", "_", "#" },
            { "=", "=", "_" },
            { "_", "_", "_" },
        };
        */
        static void Main(string[] args)
        {
            Console.WriteLine("^ up");
            Console.WriteLine("left <  > right");
            Console.WriteLine("v down");

            var view = new GathererConsoleControls();
            view.Show();

            Console.ReadKey();
        }
    }
}
