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
        public frmPause()
        {
            InitializeComponent();
            SPlayer();
            PlayMusic();
        }
        #region Variables
        public Form callinForm;

        frmGamePicture gamePicture;
        frmGame game;
        private SoundPlayer player;
        #endregion

        #region Methods
        //Music player 
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer(Properties.Resources.pop);
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

        //Close btn
        private void btnPaused_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Events of formClosing
        private void frmPause_FormClosing(object sender, FormClosingEventArgs e)
        {
            SPlayer();
            PlayMusic();
            if (callinForm is frmGamePicture)
            {
                gamePicture = (frmGamePicture)callinForm;
                gamePicture.PauseGame();
            }
            else
            {
                game = (frmGame)callinForm;
                game.PauseGame();
            }
        }
        #endregion


    }
}
