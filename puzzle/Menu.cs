using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace puzzle
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            SPlayer();
            btnMuteMenu.Image = Image.FromFile(unmute);
        }

        #region variables
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        bool active = true;
        private SoundPlayer player;
        #endregion variables

        #region methods
        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music22.wav";
            player.PlayLooping();
        }
        #endregion methods

        #region events
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame(this);
            this.Hide();
            frmGame.Show();
            player.Stop();
            frmGame.SPlayer();
        }
        private void btnPic_Click(object sender, EventArgs e)
        {
            frmGamePicture gmp = new frmGamePicture(this);
            player.Stop();
            this.Hide();
            gmp.ShowDialog();
        }
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Close();
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
                player.PlayLooping();
                active = true;
            }
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            frmCredit frmCredit = new frmCredit(this);
            player.Stop();
            this.Hide();
            frmCredit.ShowDialog();
        }
        #endregion events
    }
}
