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

        private void FrmLevelUpRu_Load(object sender, EventArgs e)
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
            lblNewStr.Text = rush.Str.ToString();
            lblNewDef.Text = rush.Def.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private Panel panel2;
        private Label label17;
        private Label label6;
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
        private Panel panel1;
        private Label label16;
        private Label label7;
        private Label lblOldLevel;
        private Label lblOldMana;
        private Label label8;
        private Label lblOldHealth;
        private Label lblOldDef;
        private Label label10;
        private Label label11;
        private Label label15;
        private Label lblOldStr;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

        #endregion
    }
}