using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace ConsoleDungeon
{
    public class LocationEventHandler :  Location, ILocationEventHandler
    {
        public void PlayerMoved(object sender, GathererPosition args)
        {
            // Console.WriteLine($"Player position is x= {args.X} y= {args.Y}");
            PrintDungeon(args);
        }

        public static void PrintDungeon(GathererPosition position)
        {
            Console.Clear();

            Console.WriteLine("^ up");
            Console.WriteLine("left <  > right");
            Console.WriteLine("v down");

            string[,] matrix = new string[LocationOne.GetLength(0), LocationOne.GetLength(1)];

            string[,] matrix = new string[position.scene.Location[position.scene.Current].Scene.GetLength(0), position.scene.Location[position.scene.Current].Scene.GetLength(1)];

            for (int i = 0; i < position.scene.Location[position.scene.Current].Scene.GetLength(0); i++)
            {
                for (int j = 0; j < position.scene.Location[position.scene.Current].Scene.GetLength(1); j++)
                {
                    switch (position.scene.Location[position.scene.Current].Scene[i, j])
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
