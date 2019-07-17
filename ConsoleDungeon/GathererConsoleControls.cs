using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace ConsoleDungeon
{
    public class GathererConsoleControls
    {
        public void Show()
        {
            var location = new GathererManager(new LocationEventHandler());
            while (true)
            {
                DirectionEnum direction = RenderOption();
                try
                {
                    switch (direction)
                    {
                        case DirectionEnum.Right:
                            {
                                location.MoveRight();
                                break;
                            }
                        case DirectionEnum.Left:
                            {
                                location.MoveLeft();
                                break;
                            }
                        case DirectionEnum.Up:
                            {
                                location.MoveUp();
                                break;
                            }
                        case DirectionEnum.Down:
                            {
                                location.MoveDown();
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                }
            }
        }

        private DirectionEnum RenderOption()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    switch (userInput.Key)
                    {
                        case ConsoleKey.LeftArrow: return DirectionEnum.Left;
                        case ConsoleKey.RightArrow: return DirectionEnum.Right;
                        case ConsoleKey.UpArrow: return DirectionEnum.Up;
                        case ConsoleKey.DownArrow: return DirectionEnum.Down;
                    }
                 }
            }
        }
    }
    
}
