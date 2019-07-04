using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Location
    {
        private static LocationObject[,] locationOne = new LocationObject[,]
        {
           { LocationObject.Player, LocationObject.Path, LocationObject.Enemy, LocationObject.Path },
           { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path, LocationObject.Path },
           { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
        };

        public static LocationObject[,] LocationOne
        {
            get
            {
                return locationOne;
            }
            set
            {
                locationOne = value;
            }
        }
    }
}

