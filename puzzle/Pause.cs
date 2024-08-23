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
using static System.Windows.Forms.DataFormats;

namespace puzzle
{

    public partial class frmPause : Form
    {
       

        public frmPause(frmGamePicture frmPic1)
        {
            InitializeComponent();
            frmPicture = frmPic1;
            SPlayer();
            PlayMusic();
        }
        #region Variables
        private frmGamePicture frmPicture;
        private SoundPlayer player;
        #endregion

        #region Methods
        //Music player 
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer();
                player.SoundLocation = @"C:\Source\Puzzle\puzzle\assets\audio\pop.wav";
                player.PlayLooping();
            }
            catch
            {
                MessageBox.Show("Error to start music player");
            }

        }
        //Play music
        public void PlayMusic()
        {
            try
            {

                player.Play();

            }
            catch
            {
                MessageBox.Show("Erro to play music");
            }

        }
        #endregion

        #region Events

        /* Close btn*/
        private void btnPaused_Click(object sender, EventArgs e)
        {
            // PlayMusic();
            Close();
        }
        /* Events of formClosing*/
        private void frmPause_FormClosing(object sender, FormClosingEventArgs e)
        {
            SPlayer();
            PlayMusic();
            frmPicture.pauseGame();



        }
        #endregion


    }
}
