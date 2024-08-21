﻿using System;
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
            frmGame frmGame = new frmGame(this);
            this.Hide();
            frmGame.Show();
            player.Stop();
            frmGame.SPlayer2();

        }
        private void picBtn_Click(object sender, EventArgs e)
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

        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music22.wav";
            player.PlayLooping();
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

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }
        public void viewMenuForm()
        {

        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void picBtn_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnExitGame_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
