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
