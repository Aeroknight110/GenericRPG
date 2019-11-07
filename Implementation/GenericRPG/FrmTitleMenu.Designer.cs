namespace GenericRPG
{
    partial class FrmTitleMenu
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
            this.game_title = new System.Windows.Forms.Label();
            this.enable_sound_label = new System.Windows.Forms.Label();
            this.new_game_button = new System.Windows.Forms.Button();
            this.enableSound = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // game_title
            // 
            this.game_title.AutoSize = true;
            this.game_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.game_title.Location = new System.Drawing.Point(539, 217);
            this.game_title.Name = "game_title";
            this.game_title.Size = new System.Drawing.Size(429, 76);
            this.game_title.TabIndex = 0;
            this.game_title.Text = "Generic RPG";
            this.game_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enable_sound_label
            // 
            this.enable_sound_label.AutoSize = true;
            this.enable_sound_label.Location = new System.Drawing.Point(654, 510);
            this.enable_sound_label.Name = "enable_sound_label";
            this.enable_sound_label.Size = new System.Drawing.Size(198, 32);
            this.enable_sound_label.TabIndex = 2;
            this.enable_sound_label.Text = "Game Options";
            // 
            // new_game_button
            // 
            this.new_game_button.Location = new System.Drawing.Point(565, 353);
            this.new_game_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(376, 74);
            this.new_game_button.TabIndex = 3;
            this.new_game_button.Text = "New Game";
            this.new_game_button.UseVisualStyleBackColor = true;
            this.new_game_button.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // enableSound
            // 
            this.enableSound.AutoSize = true;
            this.enableSound.Checked = true;
            this.enableSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableSound.Location = new System.Drawing.Point(637, 558);
            this.enableSound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableSound.Name = "enableSound";
            this.enableSound.Size = new System.Drawing.Size(233, 36);
            this.enableSound.TabIndex = 4;
            this.enableSound.Text = "Enable Sound";
            this.enableSound.UseMnemonic = false;
            this.enableSound.UseVisualStyleBackColor = true;
            this.enableSound.CheckedChanged += new System.EventHandler(this.EnableSound_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 122);
            this.panel1.TabIndex = 6;
            // 
            // FrmTitleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enableSound);
            this.Controls.Add(this.new_game_button);
            this.Controls.Add(this.enable_sound_label);
            this.Controls.Add(this.game_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTitleMenu";
            this.Text = "Generic RPG Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.Label enable_sound_label;
        private System.Windows.Forms.Button new_game_button;
        private System.Windows.Forms.CheckBox enableSound;
        private System.Windows.Forms.Panel panel1;
    }
}