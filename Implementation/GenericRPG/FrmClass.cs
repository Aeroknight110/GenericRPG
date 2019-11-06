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
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.WARRIOR;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.GetGame().Character.ClassType = classSystem.MAGICIAN;
            Console.WriteLine("You choose Mag");
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
