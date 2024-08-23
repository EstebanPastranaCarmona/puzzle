using System.Diagnostics;
using System.Media;

namespace puzzle
{
    public partial class frmCredit : Form
    {
        public frmCredit(frmMenu main2)
        {
            InitializeComponent();
            try
            {
                SPlayer();
                picLogo.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\logo.png";
                picLogo.Size = new Size(361, 104);
                main1 = main2;
                btnMuteCredit.Image = Image.FromFile(unmute);
            }
            catch
            {
                MessageBox.Show("Error to start credits");
            }
        }
        #region variables
        private frmMenu main1;
        private SoundPlayer player;
        bool active = true;
 
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        #endregion

        #region methods
        /*
         The music player is created for the credits.
         */
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer();
                player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music2.wav";
                player.PlayLooping();
            }
            catch
            {
                MessageBox.Show("Error to start music player");
            }

        }
        /*
         Function to star play the music.
         */
        public void playMusic()
        {
            try
            {
                if (active)
                {
                    player.PlayLooping();
                }
            }
            catch
            {
                MessageBox.Show("Error to play music");
            }

        }
        #endregion

        #region events
        /*Btn whit event clic for mute music*/
        private void btnMuteCredit_Click(object sender, EventArgs e)
        {
            try
            {
                if (active)
                {
                    btnMuteCredit.Image = Image.FromFile(mute);
                    active = false;
                    player.Stop();
                }
                else
                {
                    btnMuteCredit.Image = Image.FromFile(unmute);
                    active = true;
                    player.PlayLooping();
                }
            }
            catch
            {
                MessageBox.Show("Error to Mute or unmute music");
            }


        }

        /* Whe form clossing stop the music
         show menu
         play music
         */
        private void frmCredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                player.Stop();
                main1.Show();
                main1.SPlayer();
            }
            catch
            {
                MessageBox.Show("Error to close credits");
            }

        }

        //Btn for close form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Event when form load, the music start to play.
        private void frmCredit_Load(object sender, EventArgs e)
        {
            playMusic();
        }

        //Envent to go to gitHub of the proyect. 
        private void lblTittle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/EstebanPastranaCarmona/puzzle",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("No se pude abrir el enlace");
            }
        }
        //Envent to go to personal gitHub of Pasatrana. 
        private void lklblEsteban_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/EstebanPastranaCarmona",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("No se pude abrir el enlace");
            }

        }
        //Envent to go to personal gitHub of Guadamuz. 
        private void lklblJose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/joseGuadamuz2",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("No se pude abrir el enlace");
            }
        }
        #endregion
    }
}
