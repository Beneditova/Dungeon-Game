using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class LocationCollector
    {
        public List<LocationObject[,]> location = new List<LocationObject[,]>
        {
            new LocationObject[,]
            {
                 { LocationObject.Player, LocationObject.Path, LocationObject.Enemy, LocationObject.Path },
                  { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
            },

            new LocationObject[,]
            {
                  { LocationObject.Player, LocationObject.Path, LocationObject.Path, LocationObject.Terrain },
                  { LocationObject.Terrain, LocationObject.Enemy, LocationObject.Terrain, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
            }
        };


        
       
    }
}

