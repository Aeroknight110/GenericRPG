﻿namespace GenericRPG
{
    partial class FrmArena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.lblPlayerStr = new System.Windows.Forms.Label();
            this.lblPlayerDef = new System.Windows.Forms.Label();
            this.lblPlayerMana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayerGd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPlayerDamage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerXp = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnemyDamage = new System.Windows.Forms.Label();
            this.lblEnemyLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEnemyStr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEnemyDef = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEnemyMana = new System.Windows.Forms.Label();
            this.btnSimpleAttack = new System.Windows.Forms.Button();
            this.btnMagicAttack = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblEndFightMessage = new System.Windows.Forms.Label();
            this.tmrPlayerDamage = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyDamage = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerHealth.Location = new System.Drawing.Point(148, 264);
            this.lblPlayerHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerHealth.TabIndex = 1;
            this.lblPlayerHealth.Text = "label1";
            // 
            // picCharacter
            // 
            this.picCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharacter.Location = new System.Drawing.Point(32, 50);
            this.picCharacter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(237, 157);
            this.picCharacter.TabIndex = 2;
            this.picCharacter.TabStop = false;
            // 
            // lblPlayerStr
            // 
            this.lblPlayerStr.AutoSize = true;
            this.lblPlayerStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerStr.Location = new System.Drawing.Point(148, 348);
            this.lblPlayerStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerStr.Name = "lblPlayerStr";
            this.lblPlayerStr.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerStr.TabIndex = 3;
            this.lblPlayerStr.Text = "label1";
            // 
            // lblPlayerDef
            // 
            this.lblPlayerDef.AutoSize = true;
            this.lblPlayerDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerDef.Location = new System.Drawing.Point(148, 381);
            this.lblPlayerDef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerDef.Name = "lblPlayerDef";
            this.lblPlayerDef.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerDef.TabIndex = 4;
            this.lblPlayerDef.Text = "label1";
            // 
            // lblPlayerMana
            // 
            this.lblPlayerMana.AutoSize = true;
            this.lblPlayerMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerMana.Location = new System.Drawing.Point(148, 298);
            this.lblPlayerMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerMana.Name = "lblPlayerMana";
            this.lblPlayerMana.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerMana.TabIndex = 5;
            this.lblPlayerMana.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(64, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mana:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(84, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Def:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(91, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Str:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(52, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Health:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(4, 14);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(237, 28);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblPlayerDamage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPlayerXp);
            this.panel1.Controls.Add(this.lblPlayerLevel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblPlayerHealth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picCharacter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPlayerStr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPlayerDef);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPlayerMana);
            this.panel1.Location = new System.Drawing.Point(64, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 457);
            this.panel1.TabIndex = 11;
            // 
            // lblPlayerGd
            // 
            this.lblPlayerGd.AutoSize = true;
            this.lblPlayerGd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlayerGd.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerGd.Location = new System.Drawing.Point(463, 462);
            this.lblPlayerGd.Name = "lblPlayerGd";
            this.lblPlayerGd.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblPlayerGd.Size = new System.Drawing.Size(75, 28);
            this.lblPlayerGd.TabIndex = 21;
            this.lblPlayerGd.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "label12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(386, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gd:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerDamage
            // 
            this.lblPlayerDamage.AutoSize = true;
            this.lblPlayerDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDamage.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerDamage.Location = new System.Drawing.Point(184, 60);
            this.lblPlayerDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerDamage.Name = "lblPlayerDamage";
            this.lblPlayerDamage.Size = new System.Drawing.Size(108, 31);
            this.lblPlayerDamage.TabIndex = 15;
            this.lblPlayerDamage.Text = "label10";
            this.lblPlayerDamage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(84, 429);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "XP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerXp
            // 
            this.lblPlayerXp.AutoSize = true;
            this.lblPlayerXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerXp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlayerXp.Location = new System.Drawing.Point(148, 429);
            this.lblPlayerXp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerXp.Name = "lblPlayerXp";
            this.lblPlayerXp.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerXp.TabIndex = 13;
            this.lblPlayerXp.Text = "label1";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlayerLevel.Location = new System.Drawing.Point(148, 213);
            this.lblPlayerLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerLevel.TabIndex = 11;
            this.lblPlayerLevel.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(67, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Level:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEnemyDamage);
            this.panel2.Controls.Add(this.lblEnemyLevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblEnemyName);
            this.panel2.Controls.Add(this.lblEnemyHealth);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.picEnemy);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblEnemyStr);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblEnemyDef);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblEnemyMana);
            this.panel2.Location = new System.Drawing.Point(563, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 419);
            this.panel2.TabIndex = 12;
            // 
            // lblEnemyDamage
            // 
            this.lblEnemyDamage.AutoSize = true;
            this.lblEnemyDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDamage.ForeColor = System.Drawing.Color.Red;
            this.lblEnemyDamage.Location = new System.Drawing.Point(180, 60);
            this.lblEnemyDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyDamage.Name = "lblEnemyDamage";
            this.lblEnemyDamage.Size = new System.Drawing.Size(108, 31);
            this.lblEnemyDamage.TabIndex = 16;
            this.lblEnemyDamage.Text = "label10";
            this.lblEnemyDamage.Visible = false;
            // 
            // lblEnemyLevel
            // 
            this.lblEnemyLevel.AutoSize = true;
            this.lblEnemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEnemyLevel.Location = new System.Drawing.Point(155, 213);
            this.lblEnemyLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyLevel.Name = "lblEnemyLevel";
            this.lblEnemyLevel.Size = new System.Drawing.Size(70, 25);
            this.lblEnemyLevel.TabIndex = 13;
            this.lblEnemyLevel.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(73, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Level:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.Color.White;
            this.lblEnemyName.Location = new System.Drawing.Point(32, 14);
            this.lblEnemyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(237, 28);
            this.lblEnemyName.TabIndex = 10;
            this.lblEnemyName.Text = "Enemy Name";
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnemyHealth.Location = new System.Drawing.Point(155, 263);
            this.lblEnemyHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(70, 25);
            this.lblEnemyHealth.TabIndex = 1;
            this.lblEnemyHealth.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(71, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picEnemy
            // 
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.Location = new System.Drawing.Point(32, 50);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(237, 157);
            this.picEnemy.TabIndex = 2;
            this.picEnemy.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(91, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Def:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyStr
            // 
            this.lblEnemyStr.AutoSize = true;
            this.lblEnemyStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEnemyStr.Location = new System.Drawing.Point(155, 347);
            this.lblEnemyStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyStr.Name = "lblEnemyStr";
            this.lblEnemyStr.Size = new System.Drawing.Size(70, 25);
            this.lblEnemyStr.TabIndex = 3;
            this.lblEnemyStr.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(97, 347);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Str:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyDef
            // 
            this.lblEnemyDef.AutoSize = true;
            this.lblEnemyDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEnemyDef.Location = new System.Drawing.Point(155, 380);
            this.lblEnemyDef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyDef.Name = "lblEnemyDef";
            this.lblEnemyDef.Size = new System.Drawing.Size(70, 25);
            this.lblEnemyDef.TabIndex = 4;
            this.lblEnemyDef.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(59, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Health:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyMana
            // 
            this.lblEnemyMana.AutoSize = true;
            this.lblEnemyMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnemyMana.Location = new System.Drawing.Point(155, 297);
            this.lblEnemyMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyMana.Name = "lblEnemyMana";
            this.lblEnemyMana.Size = new System.Drawing.Size(70, 25);
            this.lblEnemyMana.TabIndex = 5;
            this.lblEnemyMana.Text = "label1";
            // 
            // btnSimpleAttack
            // 
            this.btnSimpleAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSimpleAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleAttack.Location = new System.Drawing.Point(408, 168);
            this.btnSimpleAttack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSimpleAttack.Name = "btnSimpleAttack";
            this.btnSimpleAttack.Size = new System.Drawing.Size(115, 53);
            this.btnSimpleAttack.TabIndex = 13;
            this.btnSimpleAttack.Text = "Simple Attack";
            this.btnSimpleAttack.UseVisualStyleBackColor = false;
            this.btnSimpleAttack.Click += new System.EventHandler(this.btnSimpleAttack_Click);
            // 
            // btnMagicAttack
            // 
            this.btnMagicAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMagicAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagicAttack.Location = new System.Drawing.Point(407, 233);
            this.btnMagicAttack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMagicAttack.Name = "btnMagicAttack";
            this.btnMagicAttack.Size = new System.Drawing.Size(115, 53);
            this.btnMagicAttack.TabIndex = 14;
            this.btnMagicAttack.Text = "Magic Attack";
            this.btnMagicAttack.UseVisualStyleBackColor = false;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(408, 297);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 53);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblEndFightMessage
            // 
            this.lblEndFightMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndFightMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndFightMessage.ForeColor = System.Drawing.Color.White;
            this.lblEndFightMessage.Location = new System.Drawing.Point(64, 500);
            this.lblEndFightMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndFightMessage.Name = "lblEndFightMessage";
            this.lblEndFightMessage.Size = new System.Drawing.Size(801, 35);
            this.lblEndFightMessage.TabIndex = 16;
            this.lblEndFightMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEndFightMessage.Visible = false;
            // 
            // tmrPlayerDamage
            // 
            this.tmrPlayerDamage.Interval = 20;
            this.tmrPlayerDamage.Tick += new System.EventHandler(this.tmrPlayerDamage_Tick);
            // 
            // tmrEnemyDamage
            // 
            this.tmrEnemyDamage.Interval = 20;
            this.tmrEnemyDamage.Tick += new System.EventHandler(this.tmrEnemyDamage_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 19);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FrmArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(941, 578);
            this.Controls.Add(this.lblPlayerGd);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEndFightMessage);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnMagicAttack);
            this.Controls.Add(this.btnSimpleAttack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmArena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArena";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmArena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.Label lblPlayerStr;
        private System.Windows.Forms.Label lblPlayerDef;
        private System.Windows.Forms.Label lblPlayerMana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEnemyStr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEnemyDef;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEnemyMana;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEnemyLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSimpleAttack;
        private System.Windows.Forms.Button btnMagicAttack;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblEndFightMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerXp;
        private System.Windows.Forms.Label lblPlayerDamage;
        private System.Windows.Forms.Label lblEnemyDamage;
        private System.Windows.Forms.Timer tmrPlayerDamage;
        private System.Windows.Forms.Timer tmrEnemyDamage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPlayerGd;
    }
}