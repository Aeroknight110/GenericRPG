using System;
using System.IO;
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
        private Weapon weapon;
        public Dictionary<int, Bitmap> imgList = new Dictionary<int, Bitmap>()
        {
            {1, Resources.smallShooter},
            {2, Resources.potion},
            {3, Resources.beamKnife},
            {4, Resources.beamAxe}
        };

        public FrmInventory()
        {
            game = Game.GetGame();
            character = game.Character;
            weapon = character.weapon;
            InitializeComponent();
            lblWeapon.Text = weapon.name.ToString();
            picWeapon.BackgroundImageLayout = ImageLayout.Stretch;
            picWeapon.BackgroundImage = imgList[weapon.wID];
            weaponTip.SetToolTip(picWeapon, weapon.descList[weapon.wID]);
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

        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
