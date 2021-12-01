using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzesciuMuszkieterówClicker
{
    internal class Boss : Entity
    {
        public string Name { get; set; }

        public Bitmap Martwy { get; set; }
        public Bitmap Zywy { get; set; }

        public System.IO.UnmanagedMemoryStream Theme { get; set; }

        public Boss(int maxHP, string name, int minAttack, int maxAttack, Bitmap martwy, Bitmap zywy, System.IO.UnmanagedMemoryStream theme)
        {
            MaxHP = maxHP;
            Name = name;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
            Martwy = martwy;
            Zywy = zywy;
            Theme = theme;
        }

    }
}
