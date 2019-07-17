using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class LocationCollector
    {
        public static List<Location> Location = new List<Location>
        {
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Player, LocationObject.Path, LocationObject.Enemy, LocationObject.Path },
                  { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
               }
            },
           
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Player, LocationObject.Path, LocationObject.Path, LocationObject.Terrain },
                  { LocationObject.Terrain, LocationObject.Enemy, LocationObject.Terrain, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
               }
            },
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Entrance, LocationObject.Path, LocationObject.Path, LocationObject.Terrain },
                  { LocationObject.Terrain, LocationObject.Path, LocationObject.Terrain, LocationObject.Terrain },
                  { LocationObject.Enemy, LocationObject.Path, LocationObject.Path, LocationObject.Exit},
               }
            }
        };
        
       private int currentIndex = 0;

        public int Current
        {
            get
            {
                return currentIndex;
            }
        }

        public bool MoveNext()
        {
            if (currentIndex != Location.Count-1)
            {
                currentIndex++;
                return true;
            }
            else return false;
        }

        public bool MoveBack()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return true;
            }
            return false;
        }
    }
}

