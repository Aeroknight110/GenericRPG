using GameLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmLevelUpRU : Form
    {
        public FrmLevelUpRU()
        {
            InitializeComponent();
        }

        private void FrmLevelUp_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"Resources\levelup.wav");
            sp.Play();

            Rush rush = Game.GetGame().Rush;
            rush.RefillHealthAndMana();

            lblOldLevel.Text = rush.Level.ToString();
            lblOldHealth.Text = ((float)Math.Round(rush.Health)).ToString();
            lblOldMana.Text = ((float)Math.Round(rush.Mana)).ToString();
            lblOldStr.Text = ((float)Math.Round(rush.Str)).ToString();
            lblOldDef.Text = ((float)Math.Round(rush.Def)).ToString();

            rush.LevelUp();
            lblNewLevel.Text = rush.Level.ToString();
            lblNewHealth.Text = rush.Health.ToString();
            lblNewMana.Text = rush.Mana.ToString();
            lblNewStr.Text =rush.Str.ToString();
            lblNewDef.Text = rush.Def.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNewLevel = new System.Windows.Forms.Label();
            this.lblNewMana = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNewHealth = new System.Windows.Forms.Label();
            this.lblNewDef = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNewStr = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOldLevel = new System.Windows.Forms.Label();
            this.lblOldMana = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOldHealth = new System.Windows.Forms.Label();
            this.lblOldDef = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblOldStr = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNewLevel);
            this.panel2.Controls.Add(this.lblNewMana);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblNewHealth);
            this.panel2.Controls.Add(this.lblNewDef);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblNewStr);
            this.panel2.Location = new System.Drawing.Point(797, 175);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 360);
            this.panel2.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(34, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 47);
            this.label17.TabIndex = 28;
            this.label17.Text = "New Stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 40);
            this.label6.TabIndex = 24;
            this.label6.Text = "Level:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewLevel
            // 
            this.lblNewLevel.AutoSize = true;
            this.lblNewLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNewLevel.Location = new System.Drawing.Point(147, 91);
            this.lblNewLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewLevel.Name = "lblNewLevel";
            this.lblNewLevel.Size = new System.Drawing.Size(119, 40);
            this.lblNewLevel.TabIndex = 23;
            this.lblNewLevel.Text = "label1";
            // 
            // lblNewMana
            // 
            this.lblNewMana.AutoSize = true;
            this.lblNewMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNewMana.Location = new System.Drawing.Point(147, 205);
            this.lblNewMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewMana.Name = "lblNewMana";
            this.lblNewMana.Size = new System.Drawing.Size(119, 40);
            this.lblNewMana.TabIndex = 18;
            this.lblNewMana.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(-3, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "Health:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewHealth
            // 
            this.lblNewHealth.AutoSize = true;
            this.lblNewHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNewHealth.Location = new System.Drawing.Point(147, 160);
            this.lblNewHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewHealth.Name = "lblNewHealth";
            this.lblNewHealth.Size = new System.Drawing.Size(119, 40);
            this.lblNewHealth.TabIndex = 15;
            this.lblNewHealth.Text = "label1";
            // 
            // lblNewDef
            // 
            this.lblNewDef.AutoSize = true;
            this.lblNewDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNewDef.Location = new System.Drawing.Point(147, 315);
            this.lblNewDef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewDef.Name = "lblNewDef";
            this.lblNewDef.Size = new System.Drawing.Size(119, 40);
            this.lblNewDef.TabIndex = 17;
            this.lblNewDef.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(15, 205);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 40);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mana:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(60, 272);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 40);
            this.label13.TabIndex = 20;
            this.label13.Text = "Str:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(50, 315);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 40);
            this.label14.TabIndex = 21;
            this.label14.Text = "Def:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewStr
            // 
            this.lblNewStr.AutoSize = true;
            this.lblNewStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNewStr.Location = new System.Drawing.Point(147, 272);
            this.lblNewStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStr.Name = "lblNewStr";
            this.lblNewStr.Size = new System.Drawing.Size(119, 40);
            this.lblNewStr.TabIndex = 16;
            this.lblNewStr.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(468, 45);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 51);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Bork Bark";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblOldLevel);
            this.panel1.Controls.Add(this.lblOldMana);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblOldHealth);
            this.panel1.Controls.Add(this.lblOldDef);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblOldStr);
            this.panel1.Location = new System.Drawing.Point(76, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 360);
            this.panel1.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(44, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 47);
            this.label16.TabIndex = 27;
            this.label16.Text = "Old Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "Level:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOldLevel
            // 
            this.lblOldLevel.AutoSize = true;
            this.lblOldLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOldLevel.Location = new System.Drawing.Point(148, 91);
            this.lblOldLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldLevel.Name = "lblOldLevel";
            this.lblOldLevel.Size = new System.Drawing.Size(119, 40);
            this.lblOldLevel.TabIndex = 23;
            this.lblOldLevel.Text = "label1";
            // 
            // lblOldMana
            // 
            this.lblOldMana.AutoSize = true;
            this.lblOldMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOldMana.Location = new System.Drawing.Point(148, 205);
            this.lblOldMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldMana.Name = "lblOldMana";
            this.lblOldMana.Size = new System.Drawing.Size(119, 40);
            this.lblOldMana.TabIndex = 18;
            this.lblOldMana.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(-2, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "Health:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOldHealth
            // 
            this.lblOldHealth.AutoSize = true;
            this.lblOldHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOldHealth.Location = new System.Drawing.Point(148, 160);
            this.lblOldHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldHealth.Name = "lblOldHealth";
            this.lblOldHealth.Size = new System.Drawing.Size(119, 40);
            this.lblOldHealth.TabIndex = 15;
            this.lblOldHealth.Text = "label1";
            // 
            // lblOldDef
            // 
            this.lblOldDef.AutoSize = true;
            this.lblOldDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOldDef.Location = new System.Drawing.Point(148, 315);
            this.lblOldDef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldDef.Name = "lblOldDef";
            this.lblOldDef.Size = new System.Drawing.Size(119, 40);
            this.lblOldDef.TabIndex = 17;
            this.lblOldDef.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(16, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 40);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mana:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(62, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 40);
            this.label11.TabIndex = 20;
            this.label11.Text = "Str:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(51, 315);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 40);
            this.label15.TabIndex = 21;
            this.label15.Text = "Def:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOldStr
            // 
            this.lblOldStr.AutoSize = true;
            this.lblOldStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOldStr.Location = new System.Drawing.Point(148, 272);
            this.lblOldStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldStr.Name = "lblOldStr";
            this.lblOldStr.Size = new System.Drawing.Size(119, 40);
            this.lblOldStr.TabIndex = 16;
            this.lblOldStr.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GenericRPG.Properties.Resources.Rush;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(432, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 376);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GenericRPG.Properties.Resources.rushpile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1169, 613);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLevelUpRU
            // 
            this.ClientSize = new System.Drawing.Size(1169, 613);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLevelUpRU";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }
    }
}