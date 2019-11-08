using GameLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmLevelUpRu : Form
    {
        public FrmLevelUpRu()
        {
            InitializeComponent();
        }

        private void FrmLevelUp_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"Resources\levelup.wav");
            sp.Play();

            Rush character = Game.GetGame().Rush;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNewStr_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblNewDef_Click(object sender, EventArgs e)
        {

        }

        private void lblNewHealth_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblNewMana_Click(object sender, EventArgs e)
        {

        }

        private void lblNewLevel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblOldLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblOldMana_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblOldHealth_Click(object sender, EventArgs e)
        {

        }

        private void lblOldDef_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblOldStr_Click(object sender, EventArgs e)
        {

        }
    }
}
