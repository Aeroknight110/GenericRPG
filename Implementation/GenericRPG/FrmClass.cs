﻿using GameLibrary;
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
            //Game.GetGame().Character.MaxHealth= 200;
            //Game.GetGame().Character.Str = 20;
            //Game.GetGame().Character.Def = 10;
            //Game.GetGame().Character.Luck = 0;
            //Game.GetGame().Character.MaxMana = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.WARRIOR;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.MAGICIAN;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.ARCHER;
            
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
