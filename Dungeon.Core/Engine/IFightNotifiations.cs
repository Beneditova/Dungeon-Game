using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
   public interface IFightNotifiations
   {
       void FightReport(FightReportArgs args);

       void WinnerReport(FightReportArgs args);
    }
}
