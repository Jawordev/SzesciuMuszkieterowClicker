
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
            this.buttonAtak1 = new System.Windows.Forms.Button();
            this.bossBar = new System.Windows.Forms.ProgressBar();
            this.ImagineBoss = new System.Windows.Forms.PictureBox();
            this.labelBossName = new System.Windows.Forms.Label();
            this.LayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutPanelAtak = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAtak2 = new System.Windows.Forms.Button();
            this.buttonAtak3 = new System.Windows.Forms.Button();
            this.buttonAtak4 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarTwojeHP = new System.Windows.Forms.ProgressBar();
            this.labelTwojeHP = new System.Windows.Forms.Label();
            this.labelBoss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagineBoss)).BeginInit();
            this.LayoutPanelMain.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.LayoutPanelAtak.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graj
            // 
            this.graj.Location = new System.Drawing.Point(318, 421);
            this.graj.Margin = new System.Windows.Forms.Padding(2);
            this.graj.Name = "graj";
            this.graj.Size = new System.Drawing.Size(134, 47);
            this.graj.TabIndex = 0;
            this.graj.Text = "Graj";
            this.graj.UseVisualStyleBackColor = true;
            this.graj.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAtak1
            // 
            this.buttonAtak1.Location = new System.Drawing.Point(2, 2);
            this.buttonAtak1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 15);
            this.buttonAtak1.Name = "buttonAtak1";
            this.buttonAtak1.Size = new System.Drawing.Size(198, 52);
            this.buttonAtak1.TabIndex = 1;
            this.buttonAtak1.Text = "Atak1";
            this.buttonAtak1.UseVisualStyleBackColor = true;
            this.buttonAtak1.Click += new System.EventHandler(this.button2_Click);
            // 
            // bossBar
            // 
            this.bossBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bossBar.ForeColor = System.Drawing.Color.Black;
            this.bossBar.Location = new System.Drawing.Point(2, 31);
            this.bossBar.Margin = new System.Windows.Forms.Padding(2);
            this.bossBar.Name = "bossBar";
            this.bossBar.Size = new System.Drawing.Size(738, 52);
            this.bossBar.Step = 1;
            this.bossBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bossBar.TabIndex = 2;
            this.bossBar.Value = 100;
            // 
            // ImagineBoss
            // 
            this.ImagineBoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagineBoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagineBoss.BackgroundImage")));
            this.ImagineBoss.Image = global::SzesciuMuszkieterówClicker.Properties.Resources.Tosiek_Boss;
            this.ImagineBoss.Location = new System.Drawing.Point(257, 2);
            this.ImagineBoss.Margin = new System.Windows.Forms.Padding(2);
            this.ImagineBoss.Name = "ImagineBoss";
            this.ImagineBoss.Size = new System.Drawing.Size(244, 310);
            this.ImagineBoss.TabIndex = 3;
            this.ImagineBoss.TabStop = false;
            this.ImagineBoss.WaitOnLoad = true;
            // 
            // labelBossName
            // 
            this.labelBossName.AutoSize = true;
            this.labelBossName.BackColor = System.Drawing.Color.YellowGreen;
            this.labelBossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBossName.Location = new System.Drawing.Point(3, 0);
            this.labelBossName.Name = "labelBossName";
            this.labelBossName.Size = new System.Drawing.Size(170, 29);
            this.labelBossName.TabIndex = 4;
            this.labelBossName.Text = "HP boss Antek";
            // 
            // LayoutPanelMain
            // 
            this.LayoutPanelMain.Controls.Add(this.labelBossName);
            this.LayoutPanelMain.Controls.Add(this.bossBar);
            this.LayoutPanelMain.Controls.Add(this.flowLayoutPanel2);
            this.LayoutPanelMain.Location = new System.Drawing.Point(1, -2);
            this.LayoutPanelMain.Name = "LayoutPanelMain";
            this.LayoutPanelMain.Size = new System.Drawing.Size(750, 418);
            this.LayoutPanelMain.TabIndex = 5;
            this.LayoutPanelMain.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LayoutPanelAtak);
            this.flowLayoutPanel2.Controls.Add(this.splitter1);
            this.flowLayoutPanel2.Controls.Add(this.ImagineBoss);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 88);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(736, 317);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // LayoutPanelAtak
            // 
            this.LayoutPanelAtak.Controls.Add(this.buttonAtak1);
            this.LayoutPanelAtak.Controls.Add(this.buttonAtak2);
            this.LayoutPanelAtak.Controls.Add(this.buttonAtak3);
            this.LayoutPanelAtak.Controls.Add(this.buttonAtak4);
            this.LayoutPanelAtak.Location = new System.Drawing.Point(3, 3);
            this.LayoutPanelAtak.Name = "LayoutPanelAtak";
            this.LayoutPanelAtak.Size = new System.Drawing.Size(200, 308);
            this.LayoutPanelAtak.TabIndex = 7;
            // 
            // buttonAtak2
            // 
            this.buttonAtak2.Location = new System.Drawing.Point(2, 84);
            this.buttonAtak2.Margin = new System.Windows.Forms.Padding(2, 15, 2, 15);
            this.buttonAtak2.Name = "buttonAtak2";
            this.buttonAtak2.Size = new System.Drawing.Size(198, 52);
            this.buttonAtak2.TabIndex = 2;
            this.buttonAtak2.Text = "Atak1";
            this.buttonAtak2.UseVisualStyleBackColor = true;
            this.buttonAtak2.Visible = false;
            // 
            // buttonAtak3
            // 
            this.buttonAtak3.Location = new System.Drawing.Point(2, 166);
            this.buttonAtak3.Margin = new System.Windows.Forms.Padding(2, 15, 2, 15);
            this.buttonAtak3.Name = "buttonAtak3";
            this.buttonAtak3.Size = new System.Drawing.Size(198, 52);
            this.buttonAtak3.TabIndex = 3;
            this.buttonAtak3.Text = "Atak1";
            this.buttonAtak3.UseVisualStyleBackColor = true;
            this.buttonAtak3.Visible = false;
            // 
            // buttonAtak4
            // 
            this.buttonAtak4.Location = new System.Drawing.Point(2, 248);
            this.buttonAtak4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 2);
            this.buttonAtak4.Name = "buttonAtak4";
            this.buttonAtak4.Size = new System.Drawing.Size(198, 52);
            this.buttonAtak4.TabIndex = 4;
            this.buttonAtak4.Text = "Atak1";
            this.buttonAtak4.UseVisualStyleBackColor = true;
            this.buttonAtak4.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(209, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(43, 308);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarTwojeHP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTwojeHP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBoss, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(506, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 308);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // progressBarTwojeHP
            // 
            this.progressBarTwojeHP.Location = new System.Drawing.Point(3, 49);
            this.progressBarTwojeHP.Name = "progressBarTwojeHP";
            this.progressBarTwojeHP.Size = new System.Drawing.Size(220, 34);
            this.progressBarTwojeHP.TabIndex = 0;
            this.progressBarTwojeHP.Value = 100;
            // 
            // labelTwojeHP
            // 
            this.labelTwojeHP.AutoSize = true;
            this.labelTwojeHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTwojeHP.Location = new System.Drawing.Point(3, 7);
            this.labelTwojeHP.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelTwojeHP.Name = "labelTwojeHP";
            this.labelTwojeHP.Size = new System.Drawing.Size(140, 31);
            this.labelTwojeHP.TabIndex = 1;
            this.labelTwojeHP.Text = "Twoje HP:";
            // 
            // labelBoss
            // 
            this.labelBoss.AutoSize = true;
            this.labelBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBoss.Location = new System.Drawing.Point(2, 106);
            this.labelBoss.Margin = new System.Windows.Forms.Padding(2, 20, 2, 20);
            this.labelBoss.Name = "labelBoss";
            this.labelBoss.Size = new System.Drawing.Size(180, 34);
            this.labelBoss.TabIndex = 2;
            this.labelBoss.Text = "Antek : Nie pokonasz mnie muhahaha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 479);
            this.Controls.Add(this.LayoutPanelMain);
            this.Controls.Add(this.graj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagineBoss)).EndInit();
            this.LayoutPanelMain.ResumeLayout(false);
            this.LayoutPanelMain.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.LayoutPanelAtak.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button graj;
        private System.Windows.Forms.Button buttonAtak1;
        private System.Windows.Forms.ProgressBar bossBar;
        private System.Windows.Forms.PictureBox ImagineBoss;
        private Label labelBossName;
        private FlowLayoutPanel LayoutPanelMain;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel LayoutPanelAtak;
        private Button buttonAtak2;
        private Button buttonAtak3;
        private Button buttonAtak4;
        private Splitter splitter1;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progressBarTwojeHP;
        private Label labelTwojeHP;
        private Label labelBoss;
    }
}

