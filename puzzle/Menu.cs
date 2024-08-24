using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading.Channels;
using System.Windows.Forms;

namespace puzzle
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            try
            {
                InitializeComponent();
                SPlayer();
                btnMuteMenu.Image = Image.FromFile(unmute);
            }
            catch 
            {
                MessageBox.Show("There was an error loading the game, the application will restart", "Error");
                string exePath = Application.ExecutablePath;
                Process.Start(exePath);
                Application.Exit();
            }
        }
        #region variables
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        bool isMusicActive = true;
        private SoundPlayer player;
        #endregion variables

        #region methods
        //Method that is responsible for reproducing music
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer();
                player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music22.wav";
                player.PlayLooping();
            }
            catch
            {
                MessageBox.Show("There was an error loading the music, please restart the application", "Alert");
            } 
        }
        #endregion methods

        #region events
        //Event that instantiates and calls the form of the game with numbers
        private void btnGame_Click(object sender, EventArgs e)
        {
            try
            {
                frmGame frmGame = new frmGame(this);
                this.Hide();
                frmGame.Show();
                player.Stop();
                frmGame.SPlayer();
            }
            catch
            {
                MessageBox.Show("It was not possible to load the game, please restart the application", "Alert");
            }
        }
        //Event that instantiates and calls the form of the game with images
        private void btnPic_Click(object sender, EventArgs e)
        {
            try
            {
                frmGamePicture gmp = new frmGamePicture(this);
                player.Stop();
                this.Hide();
                gmp.ShowDialog();
            }
            catch
            {
                MessageBox.Show("It was not possible to load the game, please restart the application", "Alert");
            }
        }
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMuteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMusicActive)
                {
                    //The image of the button that controls the music is changed to represent that the music is unmuted.
                    btnMuteMenu.Image = Image.FromFile(mute);
                    //The music is stop
                    player.Stop();
                    isMusicActive = false;
                }
                else
                {
                    //The image of the button that controls the music is changed to represent that the music is unmuted.
                    btnMuteMenu.Image = Image.FromFile(unmute);
                    //The music start again
                    player.PlayLooping();
                    isMusicActive = true;
                }
            }
            catch 
            {
                MessageBox.Show("There was an error loading the music, please restart the application", "Alert");
            }
        }
        //Event that instantiates and calls the form that has the credits
        private void btnCredit_Click(object sender, EventArgs e)
        {
            try
            {
                frmCredit frmCredit = new frmCredit(this);
                player.Stop();
                this.Hide();
                frmCredit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("It was not possible to load the credits, please restart the application", "Alert");
            }
        }
        #endregion events
    }
}
