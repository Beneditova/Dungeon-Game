﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace ConsoleDungeon
{
   public class FightNotification : IFightNotifiations
   {
       public void FightReport(FightReportArgs args)
       {
            Console.WriteLine(($"{args.GathererHero} hit {args.GathererEnemy} for {args.Attack} and scored {args.DamageRecieved}."));
       }
   }
}
