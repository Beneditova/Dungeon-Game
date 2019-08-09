using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class LocationCollector 
    {
        public List<Location> Location = new List<Location>
        {
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Entrance, LocationObject.Path, LocationObject.Path, LocationObject.Path },
                  { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Exit},
               }
            },
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Entrance, LocationObject.Path, LocationObject.Path, LocationObject.Path},
                  { LocationObject.Terrain, LocationObject.Enemy, LocationObject.Terrain, LocationObject.Terrain},
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Exit},
               }
            },
            new Location()
            {
               Scene = new LocationObject[,]
               {
                  { LocationObject.Entrance, LocationObject.Path, LocationObject.Path,  LocationObject.Path },
                  { LocationObject.Terrain, LocationObject.Path, LocationObject.Terrain,LocationObject.Path },
                  { LocationObject.Enemy, LocationObject.Path, LocationObject.Path , LocationObject.Exit },
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
        
        public List<Location> GetLocations()
        {
            return Location;
        }

        public int MaxX
        {
            get
            {
                return Location[Current].Scene.GetLength(0);
            }
        }

        public int MaxY
        {
            get
            {
                return Location[Current].Scene.GetLength(1);
            }
        }

        public bool MoveNext()
        {
            if (currentIndex != Location.Count-1)
            {
                currentIndex++;
                return true;
            }

            return false;
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

