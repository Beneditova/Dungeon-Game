using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public  class GathererSettings
    {
        private static GathererSettings _instance;

        public static GathererSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GathererSettings();
                }

                return _instance;
            }
        }

        private BaseGatherer _gathererClass;

        public BaseGatherer GathererClass
        {
            get
            {
                return _gathererClass;
            }
            set
            {
                _gathererClass = value;
            }
        }

        public void SetPlayerClass(BaseGatherer gathererClass)
        {
            GathererClass = gathererClass;
        }

        public BaseGatherer GetHeroType()
        {
            return GathererClass;
        }

    }
}
