using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public static class LocationReader 
    {
        public  static void GetLocation()
        {
            Location location = new Location();
            LocationObject[,] newLocation = new LocationObject[3, 3];

            int i = 0, j = 0;

           
            String input = File.ReadAllText("../../../locations.txt");

            foreach (var row in input.Split('\n'))
            {
              j = 0;

                foreach (var col in row.Trim().Split(','))
                {
                   switch (col.Trim())
                   {
                        case "[":
                            j = 0; i = 0;  break;
                        case "1":
                            newLocation[i, j] = LocationObject.Path; j++; break;
                        case "2":
                            newLocation[i, j] = LocationObject.Terrain; j++; break;
                        case "3":
                            newLocation[i, j] = LocationObject.Enemy; j++; break;
                        case "4":
                            newLocation[i, j] = LocationObject.Exit; j++; break;
                        case "5":
                            newLocation[i, j] = LocationObject.Entrance; j++; break;
                        case "]":
                            location.Scene = newLocation;
                            location = new Location();
                            newLocation = new LocationObject[3, 3];
                            GathererManager.area.Location.Add(location); break;
                   }
                }
                i++;
            }
        }
    }
}
