using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
   public class Location
   {
        private LocationObject[,] scene;
          
        public Location()
        {
            this.Scene = scene;
        }

        public LocationObject[,] Scene
        {
            get
            {
                return scene;
            }
            set
            {
                scene = value;
            }
        }
   }
}
