using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class frmCredit : Form
    {


        public frmCredit(frmMenu main2)
        {
            InitializeComponent();
            main1 = main2;
            SPlayer();
            btnMuteCredit.Image = Image.FromFile(unmute);
            loadImage();
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

        private void Credit_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            main1.Show();
            main1.SPlayer();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCredit_Load(object sender, EventArgs e)
        {
            playMusic();
        }

        

        private void lblLTittle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/EstebanPastranaCarmona",
                    UseShellExecute = true // Necesario para abrir la URL en el navegador
                });
            }
            catch
            {
                MessageBox.Show("No se pude abrir el enlace");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/joseGuadamuz2",
                    UseShellExecute = true // Necesario para abrir la URL en el navegador
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
