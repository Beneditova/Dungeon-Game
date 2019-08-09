using System;
using Dungeon.Core;

namespace ConsoleDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
           LocationReader.ImportLocations();

           var chooseGatherer = new ChooseGathererView();
           chooseGatherer.Show();
          
           var view = new GathererConsoleControls();
           view.Show();
          
           Console.ReadKey();
        }
    }
}
