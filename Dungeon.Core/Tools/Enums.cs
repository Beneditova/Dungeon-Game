using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public enum DirectionEnum
    {
        Right = 1,
        Left = 2,
        Up = 3,
        Down = 4,
    }

    public enum LocationObject
    {
        Path = 0,
        Player = 1,
        Terrain = 3,
        Enemy = 8
    }
    
}
