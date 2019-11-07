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
        private PictureBox[] invMap = new PictureBox[25];
        private ToolTip[] tipMap = new ToolTip[25];
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
            invMap[0] = picInv0;
            invMap[1] = picInv1;
            invMap[2] = picInv2;
            invMap[3] = picInv3;
            invMap[4] = picInv4;
            tipMap[0] = picInv0Tip;
            tipMap[1] = picInv1Tip;
            tipMap[2] = picInv2Tip;
            tipMap[3] = picInv3Tip;
            tipMap[4] = picInv4Tip;
            lblWeapon.Text = weapon.name.ToString();
            picWeapon.BackgroundImageLayout = ImageLayout.Stretch;
            picWeapon.BackgroundImage = imgList[weapon.wID];
            weaponTip.SetToolTip(picWeapon, weapon.descList[weapon.wID]);
            addItems();
        }
        public void addItems()
        {
            Item newItem;
            int i = 0;
            while (character.charInv.inv[i] != 0) {
                newItem = new Item(character.charInv.inv[i]);
                invMap[i].BackgroundImageLayout = ImageLayout.Stretch;
                invMap[i].BackgroundImage = imgList[character.charInv.inv[i]];
                tipMap[i].SetToolTip(invMap[i], newItem.descList[character.charInv.inv[i]]);
                i++;
            }
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
