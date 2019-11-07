using GameLibrary;
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
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.WARRIOR;

            Game.GetGame().Character.MaxHealth= 100;
            Game.GetGame().Character.Str = 20;
            Game.GetGame().Character.Def = 4;
            Game.GetGame().Character.Luck = 0;
            Game.GetGame().Character.MaxMana = 10;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.MAGICIAN;
            Game.GetGame().Character.MaxHealth = 50;
            Game.GetGame().Character.Str = 5;
            Game.GetGame().Character.Def = 1;
            Game.GetGame().Character.Luck = 5;
            Game.GetGame().Character.MaxMana = 60;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.ARCHER;
            Game.GetGame().Character.MaxHealth = 50;
            Game.GetGame().Character.Str = 15;
            Game.GetGame().Character.Def = 2;
            Game.GetGame().Character.Luck = 10;
            Game.GetGame().Character.MaxMana = 30;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
