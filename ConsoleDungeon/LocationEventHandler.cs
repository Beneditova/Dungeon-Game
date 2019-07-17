using System;
using Dungeon.Core;

namespace ConsoleDungeon
{
    public class LocationEventHandler :  ILocationEventHandler
    {
        public void PlayerMoved(object sender, GathererPosition args)
        {
            PrintDungeon(args);
        }

        private static void PrintDungeon(GathererPosition position)
        {
            Console.Clear();
            Console.WriteLine("[Game Controls]");
            Console.WriteLine("^ up");
            Console.WriteLine("left <  > right");
            Console.WriteLine("v down");

            string[,] matrix = new string[position.Scene.Location[position.Scene.Current].Scene.GetLength(0), position.Scene.Location[position.Scene.Current].Scene.GetLength(1)];

            for (int i = 0; i < position.Scene.Location[position.Scene.Current].Scene.GetLength(0); i++)
            {
                for (int j = 0; j < position.Scene.Location[position.Scene.Current].Scene.GetLength(1); j++)
                {
                    switch (position.Scene.Location[position.Scene.Current].Scene[i, j])
                    {
                        case LocationObject.Path:
                            matrix[i, j] = "_";
                            break;
                        case LocationObject.Terrain:
                            matrix[i, j] = "=";
                            break;
                        case LocationObject.Entrance:
                            matrix[i, j] = "(";
                            break;
                        case LocationObject.Enemy:
                            matrix[i, j] = "#";
                            break;
                        case LocationObject.Exit:
                            matrix[i, j] = ")";
                            break;
                    }
                }
            }

            Console.WriteLine();

            matrix[position.X, position.Y] = "$";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\n\n");
            
        }
       
    }  
}

