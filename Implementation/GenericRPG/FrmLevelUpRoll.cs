﻿using GameLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmLevelUpRL : Form
    {
        public FrmLevelUpRL()
        {
            InitializeComponent();
        }

        private void FrmLevelUp_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"Resources\levelup.wav");
            sp.Play();

            Roll character = Game.GetGame().Roll;
            character.RefillHealthAndMana();

            lblOldLevel.Text = character.Level.ToString();
            lblOldHealth.Text = ((float)Math.Round(character.Health)).ToString();
            lblOldMana.Text = ((float)Math.Round(character.Mana)).ToString();
            lblOldStr.Text = ((float)Math.Round(character.Str)).ToString();
            lblOldDef.Text = ((float)Math.Round(character.Def)).ToString();

            character.LevelUp();
            lblNewLevel.Text = character.Level.ToString();
            lblNewHealth.Text = character.Health.ToString();
            lblNewMana.Text = character.Mana.ToString();
            lblNewStr.Text = character.Str.ToString();
            lblNewDef.Text = character.Def.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOldLevel = new System.Windows.Forms.Label();
            this.lblOldMana = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOldHealth = new System.Windows.Forms.Label();
            this.lblOldDef = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldStr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblOldLevel);
            this.panel1.Controls.Add(this.lblOldMana);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblOldHealth);
            this.panel1.Controls.Add(this.lblOldDef);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblOldStr);
            this.panel1.Location = new System.Drawing.Point(36, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 363);
            this.panel1.TabIndex = 40;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(16, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 40);
            this.label6.TabIndex = 24;
            this.label6.Text = "Level:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(-2, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "Health:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(16, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mana:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(62, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Str:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(51, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Def:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GenericRPG.Properties.Resources.rushpile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GenericRPG.Properties.Resources.cinroll;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 592);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 40);
            this.label5.TabIndex = 24;
            this.label5.Text = "Level:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblNewHealth.Size = new System.Drawing.Size(241, 40);
            this.lblNewHealth.TabIndex = 15;
            this.lblNewHealth.Text = "lblNewHealth";
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
            this.btnClose.ForeColor = System.Drawing.Color.DeepPink;
            this.btnClose.Location = new System.Drawing.Point(331, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(327, 51);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Let\'s ROLL Out";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblNewLevel);
            this.panel2.Controls.Add(this.lblNewMana);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblNewHealth);
            this.panel2.Controls.Add(this.lblNewDef);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblNewStr);
            this.panel2.Location = new System.Drawing.Point(669, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 360);
            this.panel2.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::GenericRPG.Properties.Resources.roll;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::GenericRPG.Properties.Resources.roll;
            this.pictureBox2.Location = new System.Drawing.Point(345, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 492);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // FrmLevelUpRL
            // 
            this.ClientSize = new System.Drawing.Size(973, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLevelUpRL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Label label16;
        private Label label6;
        private Label lblOldLevel;
        private Label lblOldMana;
        private Label label4;
        private Label lblOldHealth;
        private Label lblOldDef;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblOldStr;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label5;
        private Label lblNewLevel;
        private Label lblNewMana;
        private Label label9;
        private Label lblNewHealth;
        private Label lblNewDef;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblNewStr;
        private Button btnClose;
        private Panel panel2;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox2;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
