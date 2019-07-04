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

        public static void PrintDungeon(GathererPosition playerPosition)
        {
            Console.Clear();

            Console.WriteLine("^ up");
            Console.WriteLine("left <  > right");
            Console.WriteLine("v down");

            string[,] matrix = new string[LocationOne.GetLength(0), LocationOne.GetLength(1)];

            for (int i = 0; i < LocationOne.GetLength(0); i++)
            {
                for (int j = 0; j < LocationOne.GetLength(1); j++)
                {
                    if (LocationOne[i, j] == LocationObject.Path)
                    {
                        matrix[i, j] = "_";
                    }

                    if (LocationOne[i, j] == LocationObject.Terrain)
                    {
                        matrix[i, j] = "=";
                    }

                    if (LocationOne[i, j] == LocationObject.Enemy)
                    {
                        matrix[i, j] = "#";
                    }
                }
            }

            Console.WriteLine();

            matrix[playerPosition.X, playerPosition.Y] = "$";

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
