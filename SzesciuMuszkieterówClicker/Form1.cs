using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzesciuMuszkieterówClicker.Klasy;
using SzesciuMuszkieterówClicker.Properties;

namespace SzesciuMuszkieterówClicker
{
    public partial class Form1 : Form
    {
        Gra gra;
        System.Media.SoundPlayer music;
        public Form1()
        {
            InitializeComponent();
            gra = new Gra();
            music = new System.Media.SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            music.Stop();
            BackgroundImage = null;
            BackColor = Color.White;
            LayoutPanelAtak.Visible = true;
            LayoutPanelMain.Visible = true;
            gra.NextBoss();
            ImagineBoss.Image = gra.CurrentBoss.Zywy;
            bossBar.Maximum = gra.CurrentBoss.MaxHP;
            bossBar.Value = gra.CurrentBoss.MaxHP;
            bossBar.SetState(1);
            graj.Enabled = false;
            graj.Text = "Next";
            labelBossName.Text = "Boss " + gra.CurrentBoss.Name + " HP:";
            music.Stream = gra.CurrentBoss.Theme;
            music.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int attackGracza = gra.Gracz.CalculateAttack();
            int attackBossa = gra.CurrentBoss.CalculateAttack();
            if (bossBar.Value - attackGracza >= 0)
            {
                bossBar.Value -= attackGracza;
            }
            else
            {
                bossBar.SetState(1);
                bossBar.Value = 0;
                ImagineBoss.Image = gra.CurrentBoss.Martwy;
                graj.Enabled = true;
                LayoutPanelAtak.Visible = false;
            }
            if (progressBarTwojeHP.Value - attackBossa >= 0)
            {
                progressBarTwojeHP.Value -= attackBossa;
            }
            else
            {
                progressBarTwojeHP.SetState(1);
                progressBarTwojeHP.Value = 0;
                MessageBox.Show("LOsser");
                LayoutPanelAtak.Visible = false;

            }

            progressBarTwojeHP.SetState(CalculateState(progressBarTwojeHP.Value, gra.Gracz.MaxHP));
            bossBar.SetState(CalculateState(bossBar.Value, gra.CurrentBoss.MaxHP));
        }

        private int CalculateState(int i, int max)
        {
            if(i > max * 0.5)
            {
                return 1;
            }else if( i > max * 0.2)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        private void Intro()
        {
            BackgroundImage = Resources.logoMuszkieterow;
            music.Stream = Resources.MainTheme;
            music.PlayLooping();
            BackColor = Color.Black;
            graj.Visible = false;
            for(int i = 0; i < 100; i++)
            {
                Opacity = 0.01 * i;
                Thread.Sleep(30);
            }
            
            
            graj.Visible = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Intro();
        }
    }
}
