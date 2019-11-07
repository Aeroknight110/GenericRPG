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
    public partial class FrmShop : Form
    {
        private Game game;
        private Character character;
        private PictureBox[] invMap = new PictureBox[25];
        private ToolTip[] tipMap = new ToolTip[25];
        public Dictionary<int, Bitmap> imgList = new Dictionary<int, Bitmap>()
        {
            {1, Resources.smallShooter},
            {2, Resources.potion},
            {3, Resources.beamKnife},
            {4, Resources.beamAxe}
        };
        public Dictionary<int, string> priceList = new Dictionary<int, string>()
        {
            {1, "Price: 250 Gb"},
            {2, "Price: 100 Gb"},
            {3, "Price: 500 Gb"},
            {4, "Price: 600 Gb"}
        };

        public FrmShop()
        {
            InitializeComponent();
            game = Game.GetGame();
            character = game.Character;
            coinBox.BackgroundImageLayout = ImageLayout.Stretch;
            coinBox.BackgroundImage = Resources.coin;
            lblCharGb.Text = Math.Ceiling(character.Gb).ToString();
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
            if(invMap[0].BackgroundImage == null)
                addItems(4);
        }

        public void addItems(int j)
        {
            Item newItem;
            int iter = 0;
            Random rand = new Random();
            int i = 0;
            int temp;
            while (i < j)
            {
                iter = rand.Next(1,5);
                newItem = new Item(iter);
                invMap[i].BackgroundImageLayout = ImageLayout.Stretch;
                invMap[i].BackgroundImage = imgList[iter];
                tipMap[i].SetToolTip(invMap[i], newItem.descList[iter]);
                i++;
            }
        }

        private void closeShop()
        {
            game.ChangeState(GameState.ON_MAP);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeShop();
        }
    }
}
