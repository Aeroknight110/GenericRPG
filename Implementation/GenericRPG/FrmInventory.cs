using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;
using GenericRPG.Properties;

namespace GenericRPG
{
    public partial class FrmInventory : Form
    {
        private Game game;
        private Character character;
        
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeInv();
        }
        private void closeInv()
        {
            Game.GetGame().ChangeState(GameState.ON_MAP);
            Close();
        }
    }
}
