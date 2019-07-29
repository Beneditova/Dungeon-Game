using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon.Core;

namespace ConsoleDungeon
{
   public class ChooseGathererView
    {
        public void Show()
        {
            var monk = new Monk(100, 10, 10);
            var mage = new Mage(100, 10, 10); 
            var rogue = new Rogue(100, 10, 10); 
            var warrior = new Warrior(200, 10, 20);
           

            ChooseGatherer gatherer =  GathererOption();
                switch (gatherer)
                {
                    case ChooseGatherer.Monk: GathererSettings.Instance.GathererClass = monk; break;
                    case ChooseGatherer.Mage: GathererSettings.Instance.GathererClass = mage;  break;
                    case ChooseGatherer.Rogue: GathererSettings.Instance.GathererClass = rogue; break;
                    case ChooseGatherer.Warrior: GathererSettings.Instance.GathererClass = warrior; break;
                }
        }
       
        private ChooseGatherer GathererOption()
        {
            Console.WriteLine("Choose Your Epic Hero [Monk,Mage,Rogue or Warrior]");
            string option = Console.ReadLine();
            switch (option.ToLower())
            {
                case "monk": return ChooseGatherer.Monk;
                case "mage": return ChooseGatherer.Mage;
                case "rogue": return ChooseGatherer.Rogue;
                case "warrior": return ChooseGatherer.Warrior;
                default: return ChooseGatherer.Warrior;
            }
        }
    }
}
