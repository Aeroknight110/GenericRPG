﻿using GameLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmLevelUpRush : Form
    {
        public FrmLevelUpRush()
        {
            InitializeComponent();
        }

        private void FrmLevelUpRush_Load(object sender, EventArgs e)
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
    }
}
