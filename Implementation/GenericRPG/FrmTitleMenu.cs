using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmTitleMenu : Form
    {
        public FrmTitleMenu()
        {
            InitializeComponent();
        }

        /// When the "Play Game" button is pressed, close the menu and open the game
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMap gameMap = new FrmMap();
            gameMap.ShowDialog();   
        }
        
        /// Import to Change the Sound in the Game
        [DllImport("winmm.dll")]
        private static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);

        /// Sets the Volume of the Game
        public static void SetVolume(int volume)
        {
            int NewVolume = ((ushort.MaxValue / 10) * volume);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            WaveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        /// If the Enable Sound box is checked, sets volume to 10. Otherwise, 0.
        private void EnableSound_CheckedChanged(object sender, EventArgs e)
        {
            int volumeLevel = (enableSound.Checked == true) ? 10 : 0;
            SetVolume(volumeLevel);
        }
    }
}
