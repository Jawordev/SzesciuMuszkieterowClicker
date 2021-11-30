using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzesciuMuszkieterówClicker.Klasy
{
    class Gra
    {
        public Boss CurrentBoss { get; set; }
        public Bosses Bosses { get; set; }
        public Gracz Gracz { get; set; }

        private int level = 0;
        public Gra()
        {
            Gracz = new Gracz(100, 5, 15);
            Bosses = new Bosses();
        }
    
        public void NextBoss()
        {
            CurrentBoss = Bosses.BossesList[level];

            if(level+1 < Bosses.BossesList.Count)
            {
                level++;
            }
        }
    }
}
