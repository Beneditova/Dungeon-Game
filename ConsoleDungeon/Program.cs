using System;
using Dungeon.Core;

namespace ConsoleDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new GathererConsoleControls();
            view.Show();

            Console.ReadKey();
        }
    }
}


