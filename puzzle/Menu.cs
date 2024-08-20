using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace puzzle
{
    public partial class frmMenu : Form
    {
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        bool active = true;
        private SoundPlayer player;
        public frmMenu()
        {
            InitializeComponent();
            btnMuteMenu.Image = Image.FromFile(unmute);
            SPlayer();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame();
            frmGame.Show();
            player.Stop();
            frmGame.SPlayer2();
            this.Hide();
        }
        private void picBtn_Click(object sender, EventArgs e)
        {
            gamePicture gmp = new gamePicture();
            player.Stop();
            this.Hide();
            gmp.ShowDialog();
            
        }
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music1.wav";
            player.Play();
        }
        private void btnMuteMenu_Click(object sender, EventArgs e)
        {
            if (active)
            {
                btnMuteMenu.Image = Image.FromFile(mute);
                player.Stop();
                active = false;
            }
            else
            {
                btnMuteMenu.Image = Image.FromFile(unmute);
                player.Play();
                active = true;
            }
        }
    }
}
