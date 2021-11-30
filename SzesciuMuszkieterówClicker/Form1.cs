using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzesciuMuszkieterówClicker.Properties;

namespace SzesciuMuszkieterówClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graj.Visible = false;
            atakS.Visible = true;
            bossBar.Visible = true;
            TosiekBoss.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bossBar.Value > 10)
            {
                Random atk1 = new Random();
                int damage = atk1.Next(2, 10);
                bossBar.Value -= damage;
            }
            else
            {
                TosiekBoss.Image = Resources.Tosiek_BossDead;
                bossBar.Value = 0;
            }
        }

    }
}
