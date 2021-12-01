using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzesciuMuszkieterówClicker
{
    internal class Gracz : Entity
    {
        public Gracz(int maxHP, int minAttack, int maxAttack)
        {
            MaxHP = maxHP;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }

    }
}
