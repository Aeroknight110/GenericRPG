using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class LevelUpAddStat : Form
    {
        public LevelUpAddStat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameLibrary.Game.GetGame().Character.Str += 2;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            GameLibrary.Game.GetGame().Character.Def += 2;
            GameLibrary.Game.GetGame().Character.MaxHealth += 10;
            GameLibrary.Game.GetGame().Character.Health = GameLibrary.Game.GetGame().Character.MaxHealth;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            GameLibrary.Game.GetGame().Character.MaxMana += 20;
            GameLibrary.Game.GetGame().Character.Mana = GameLibrary.Game.GetGame().Character.MaxMana;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameLibrary.Game.GetGame().Character.Luck += 3;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LevelUpAddStat_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
