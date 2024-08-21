using System.Diagnostics;
using System.Media;

namespace puzzle
{
    public partial class frmCredit : Form
    {
        public frmCredit(frmMenu main2)
        {
            InitializeComponent();
            SPlayer();
            loadImage();

            main1 = main2;
            btnMuteCredit.Image = Image.FromFile(unmute);
        }
        #region variables
        private frmMenu main1;
        private SoundPlayer player;
        bool active = true;
 
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        #endregion

        #region methods
        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music2.wav";
            player.Play();
        }
        public void playMusic()
        {
            if (active)
            {
                player.Play();
            }
        }
        public void loadImage()
        {
            picLogo.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\logo.png";
            picLogo.Size = new Size(361, 104);
        }
        #endregion

        #region events
        private void btnMuteCredit_Click(object sender, EventArgs e)
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
                player.Play();
            }
        }
        private void frmCredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            main1.Show();
            main1.SPlayer();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmCredit_Load(object sender, EventArgs e)
        {
            playMusic();
        }
        private void lblTittle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/EstebanPastranaCarmona/puzzle",
                    UseShellExecute = true // Necesario para abrir la URL en el navegador
                });
            }
            catch
            {
                MessageBox.Show("No se pude abrir el enlace");
            }
        }
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
