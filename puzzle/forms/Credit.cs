﻿using System.Diagnostics;
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
                picLogo.Image = Properties.Resources.logo;
                picLogo.Size = new Size(361, 104);
                main1 = main2;
                btnMuteCredit.Image = Properties.Resources.unmute;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error to start credits Details{ex.Message}");
                this.Close();   
            }
        }
        #region variables
        private frmMenu main1;
        private SoundPlayer player;
        bool active = true;
 
        #endregion

        #region methods
         //The music player is created for the credits.
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer(Properties.Resources.music2);

                player.PlayLooping();
            }
            catch
            {
                MessageBox.Show("Error to start music player");
            }
        }
        //Function to star play the music.
        public void PlayMusic()
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
        //Btn whit event clic for mute music
        private void btnMuteCredit_Click(object sender, EventArgs e)
        {
            try
            {
                if (active)
                {
                    btnMuteCredit.Image = Properties.Resources.mute;
                    active = false;
                    player.Stop();
                }
                else
                {
                    btnMuteCredit.Image = Properties.Resources.unmute;
                    active = true;
                    player.PlayLooping();
                }
            }
            catch
            {
                MessageBox.Show("Error to Mute or unmute music");
            }
        }
        private void frmCredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Whe form clossing stop the music
                player.Stop();
                //show menu
                main1.Show();
                //play music of the menu form
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
            PlayMusic();
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
