using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzesciuMuszkieterówClicker
{
    internal abstract class Entity
    {
        public int MaxHP { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

        public int CalculateAttack()
        {
            Random atk1 = new Random();
            return atk1.Next(MinAttack, MaxAttack);
        }

    }
}
