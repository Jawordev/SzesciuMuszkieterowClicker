using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzesciuMuszkieterówClicker.Properties;

namespace SzesciuMuszkieterówClicker.Klasy
{
    internal class Bosses
    {
        public List<Boss> BossesList { get; set; }

        public Bosses()
        {
            BossesList = new List<Boss>();
            BossesList.Add(new Boss(100, "Antek", 0, 5, Resources.Tosiek_BossDead, Resources.Tosiek_Boss, Resources.AntekTheme));
            BossesList.Add(new Boss(150, "Mati G.", 5, 10, Resources.Tosiek_BossDead, Resources.Tosiek_Boss, Resources.GembaTheme));
        }

        
    }
}
