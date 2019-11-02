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
            this.play_game_button = new System.Windows.Forms.Button();
            this.enableSound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // game_title
            // 
            this.game_title.AutoSize = true;
            this.game_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.game_title.Location = new System.Drawing.Point(552, 46);
            this.game_title.Name = "game_title";
            this.game_title.Size = new System.Drawing.Size(429, 76);
            this.game_title.TabIndex = 0;
            this.game_title.Text = "Generic RPG";
            this.game_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enable_sound_label
            // 
            this.enable_sound_label.AutoSize = true;
            this.enable_sound_label.Location = new System.Drawing.Point(654, 414);
            this.enable_sound_label.Name = "enable_sound_label";
            this.enable_sound_label.Size = new System.Drawing.Size(198, 32);
            this.enable_sound_label.TabIndex = 2;
            this.enable_sound_label.Text = "Game Options";
            // 
            // play_game_button
            // 
            this.play_game_button.Location = new System.Drawing.Point(565, 216);
            this.play_game_button.Name = "play_game_button";
            this.play_game_button.Size = new System.Drawing.Size(376, 73);
            this.play_game_button.TabIndex = 3;
            this.play_game_button.Text = "Play Game";
            this.play_game_button.UseVisualStyleBackColor = true;
            this.play_game_button.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // enableSound
            // 
            this.enableSound.AutoSize = true;
            this.enableSound.Location = new System.Drawing.Point(637, 461);
            this.enableSound.Name = "enableSound";
            this.enableSound.Size = new System.Drawing.Size(233, 36);
            this.enableSound.TabIndex = 4;
            this.enableSound.Text = "Enable Sound";
            this.enableSound.UseVisualStyleBackColor = true;
            this.enableSound.CheckedChanged += new System.EventHandler(this.EnableSound_CheckedChanged);
            // 
            // FrmTitleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 843);
            this.Controls.Add(this.enableSound);
            this.Controls.Add(this.play_game_button);
            this.Controls.Add(this.enable_sound_label);
            this.Controls.Add(this.game_title);
            this.Name = "FrmTitleMenu";
            this.Text = "FrmTitleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.Label enable_sound_label;
        private System.Windows.Forms.Button play_game_button;
        private System.Windows.Forms.CheckBox enableSound;
    }
}