
using System.Windows.Forms;

namespace SzesciuMuszkieterówClicker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graj = new System.Windows.Forms.Button();
            this.atakS = new System.Windows.Forms.Button();
            this.bossBar = new System.Windows.Forms.ProgressBar();
            this.TosiekBoss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TosiekBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // graj
            // 
            this.graj.Location = new System.Drawing.Point(315, 308);
            this.graj.Name = "graj";
            this.graj.Size = new System.Drawing.Size(178, 58);
            this.graj.TabIndex = 0;
            this.graj.Text = "Graj";
            this.graj.UseVisualStyleBackColor = true;
            this.graj.Click += new System.EventHandler(this.button1_Click);
            // 
            // atakS
            // 
            this.atakS.Location = new System.Drawing.Point(63, 308);
            this.atakS.Name = "atakS";
            this.atakS.Size = new System.Drawing.Size(134, 64);
            this.atakS.TabIndex = 1;
            this.atakS.Text = "Atak1";
            this.atakS.UseVisualStyleBackColor = true;
            this.atakS.Visible = false;
            this.atakS.Click += new System.EventHandler(this.button2_Click);
            // 
            // bossBar
            // 
            this.bossBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bossBar.ForeColor = System.Drawing.Color.Black;
            this.bossBar.Location = new System.Drawing.Point(23, 12);
            this.bossBar.Name = "bossBar";
            this.bossBar.Size = new System.Drawing.Size(727, 23);
            this.bossBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bossBar.TabIndex = 2;
            this.bossBar.Value = 100;
            this.bossBar.Visible = false;
            // 
            // TosiekBoss
            // 
            this.TosiekBoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TosiekBoss.BackgroundImage")));
            this.TosiekBoss.Image = global::SzesciuMuszkieterówClicker.Properties.Resources.Tosiek_Boss;
            this.TosiekBoss.Location = new System.Drawing.Point(268, 41);
            this.TosiekBoss.Name = "TosiekBoss";
            this.TosiekBoss.Size = new System.Drawing.Size(261, 261);
            this.TosiekBoss.TabIndex = 3;
            this.TosiekBoss.TabStop = false;
            this.TosiekBoss.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TosiekBoss);
            this.Controls.Add(this.bossBar);
            this.Controls.Add(this.atakS);
            this.Controls.Add(this.graj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TosiekBoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button graj;
        private System.Windows.Forms.Button atakS;
        private System.Windows.Forms.ProgressBar bossBar;
        private System.Windows.Forms.PictureBox TosiekBoss;
    }
}

