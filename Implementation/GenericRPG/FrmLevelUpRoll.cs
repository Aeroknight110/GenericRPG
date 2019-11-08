using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using System.Windows.Forms;
using GameLibrary;

namespace GenericRPG
{
    public partial class FrmLevelUpRoll : Form
    {
        public FrmLevelUpRoll()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
