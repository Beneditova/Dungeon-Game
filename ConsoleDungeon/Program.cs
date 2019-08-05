using System;
using Dungeon.Core;

namespace ConsoleDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            LocationReader.GetLocation();
            
            var chooseGatherer = new ChooseGathererView();
            chooseGatherer.Show();
           
            var view = new GathererConsoleControls();
            view.Show();

            Console.ReadKey();
        }
    }
}


