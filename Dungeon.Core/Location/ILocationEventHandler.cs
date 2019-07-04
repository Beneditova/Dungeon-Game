using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public interface ILocationEventHandler
    {
        void PlayerMoved(object sender, GathererPosition args);
    }
}
