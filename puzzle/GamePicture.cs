﻿using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Media;
using System.Net.Http.Headers;

namespace puzzle
{
    public partial class frmGamePicture : Form
    {
       

        public frmGamePicture(frmMenu main2)
        {
            InitializeComponent();
            try 
            {
                SPlayer();
                LoadList();
                Shuffle(random);
                RandomImages();
                LoadMatrix();
                LoadGame();

                main1 = main2;

                btnMuteGame.Image = Image.FromFile(unmute);
                btnPauseGame.Image = Image.FromFile(pause);
                originalPictureBox.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\original.jpg";

                tmtTimer.Start();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"There was an error loading the game, the application will restart Details: {ex.Message}", "Error");
                string exePath = Application.ExecutablePath;
                Process.Start(exePath);
                Application.Exit();
            }   
        }
        #region variables
        Random random = new Random();
        List<string> routeOrdered = new List<string>();
        List<string> movements = new List<string>();
        List<int> numbers = new List<int>([0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        private SoundPlayer player;
        private frmMenu main1;

        PictureBox[,] pictures = new PictureBox[4, 4];
        int pictureIndex = 0;

        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        public string play = @"C:\Source\Puzzle\puzzle\assets\icon\play.png";
        public string pause = @"C:\Source\Puzzle\puzzle\assets\icon\pause.png";
        bool isMusicActive = true;
        private bool isGameActive = true;
        
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        #endregion variables

        #region methods
        //The matrix is ​​loaded with the pictureboxes of the groupBox
        public void LoadMatrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pictureIndex < gbxImages.Controls.Count)
                    {
                        pictures[i, j] = (PictureBox)gbxImages.Controls[pictureIndex];
                        pictureIndex++;
                    }
                }
            }
        }
        //loadlist is responsible for loading the location of images in the list.
        public void LoadList()
        {
            try 
            {
                for (int i = 0; i <= 15; i++)
                {
                    routeOrdered.Add($@"C:\Source\Puzzle\puzzle\assets\img\{i}.jpg");
                }
            }
            catch
            {
                MessageBox.Show("Error to load list");
            }
        }
        //loadGame is responsible for load images in the pictureBox.
        public void LoadGame()
        {
            try
            {
                int index = 0;
                foreach (PictureBox pic in gbxImages.Controls)
                {
                    pic.ImageLocation = movements[index];
                    index++;
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show($"Error to load game, Details: {ex.Message}");
                this.Close();
            }
        }
        //loadGame copy items of the routeOrdered list to movement list in random posistions.
        public void RandomImages()
        {
            try
            {
                for (int i = 0; i < randomNumbers.Count; i++)
                {
                    var pos = randomNumbers[i];
                    movements.Add(routeOrdered[pos]);
                }
                movements.Add(routeOrdered[15]);
            }
            catch { MessageBox.Show("Error to random images"); }
        }
        //endGame 
        public void EndGame()
        {
            try
            {
                //List where the current positions of the images in the matrix are saved
                List<string> actualPictures = new List<string>();
                //The list of groupbox controls is iterated
                for (int i = 0; i < gbxImages.Controls.Count; i++)
                {
                    //The pictureBox is saved in a temporary variable
                    PictureBox temp = (PictureBox)gbxImages.Controls[i];
                    //The address of the image is saved in the list, thus obtaining the order of the images in the matrix
                    actualPictures.Add(temp.ImageLocation);
                }
                //It compares that the current sequence in the array is equal to the ordered list of the image
                if (actualPictures.SequenceEqual(routeOrdered))
                {
                    //A frmPause is instantiated and the time in which the player finished the game is passed.
                    frmWin win = new frmWin($" {hours:D2}:{minutes:D2}:{seconds:D2}");
                    //the timer stops
                    tmtTimer.Stop();
                    //The callingForm space is assigned this form
                    win.callingForm = this;
                    win.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Error to execute end game");
            }
        }
        //Music player 
        public void SPlayer()
        {
            try
            {
                player = new SoundPlayer();
                player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music33.wav";
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
                if (isMusicActive)
                {
                    player.PlayLooping();
                }
            } 
            catch
            {
                MessageBox.Show("Erro to play music");
            }
        }
        //Shufle position 
        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next()).ToList();
        }

        public void PauseGame()
        {
            try
            {
                //Check that the game is active
                if (isGameActive)
                {
                    //The image of the pause button is changed
                    btnPauseGame.Image = Image.FromFile(play);
                    //The stopwatch stops
                    tmtTimer.Stop();
                    //The music stops
                    player.Stop();
                    isGameActive = false;

                    frmPause pauseForm = new frmPause();
                    pauseForm.callinForm = this;
                    pauseForm.ShowDialog();
                }
                else
                {
                    //The image of the pause button is changed
                    btnPauseGame.Image = Image.FromFile(pause);
                    //The stopwatch starts
                    tmtTimer.Start();
                    //The Music starts
                    player.Play();
                    isGameActive = true;
                }
            }
            catch
            {
                MessageBox.Show("Error to pause Game");
            }
        }
        #endregion methods

        #region events

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pictureClicked = (PictureBox)sender;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pictureClicked == pictures[i, j])
                    {
                        try
                        {
                            if (pictures[i, j + 1].ImageLocation == movements[15])
                            {
                                var temporary = pictures[i, j + 1].ImageLocation;
                                pictures[i, j + 1].ImageLocation = pictures[i, j].ImageLocation;
                                pictures[i, j].ImageLocation = temporary;
                                EndGame();
                            }
                        }
                       catch { }
                        try
                        {
                            if (pictures[i, j - 1].ImageLocation == movements[15] )
                            {
                                    var temporary = pictures[i, j - 1].ImageLocation;
                                    pictures[i, j - 1].ImageLocation = pictures[i, j].ImageLocation;
                                    pictures[i, j].ImageLocation = temporary;
                                    EndGame();
                            }
                        }
                        catch { }
                        try
                        {
                            if (pictures[i + 1, j].ImageLocation == movements[15])
                            {
                                    var temporary = pictures[i + 1, j].ImageLocation;
                                    pictures[i + 1, j].ImageLocation = pictures[i, j].ImageLocation;
                                    pictures[i, j].ImageLocation = temporary;
                                    EndGame();
                            }
                        }
                        catch { }
                        try
                        {
                            if (pictures[i - 1, j].ImageLocation == movements[15])
                            {
                                    var temporary = pictures[i - 1, j].ImageLocation;
                                    pictures[i - 1, j].ImageLocation = pictures[i, j].ImageLocation;
                                    pictures[i, j].ImageLocation = temporary;
                                    EndGame();
                            }
                        }
                        catch { }
                    }
                }
            }
        }
        //Mute and unmute music.
        private void btnMuteGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMusicActive && isGameActive)
                {
                    btnMuteGame.Image = Image.FromFile(mute);
                    player.Stop();
                    isMusicActive = false;
                }
                else if (!isMusicActive && isGameActive)
                {
                    btnMuteGame.Image = Image.FromFile(unmute);
                    player.PlayLooping();
                    isMusicActive = true;
                }
            }
            catch
            {
                MessageBox.Show("Error for mute or unmute music");
            }
        }
        //Pause and play menu.
        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            PauseGame();
        }
        //Timmer of player.
        private void tmtTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                seconds++;
                tmtTimer.Interval = 1000;
                if (seconds > 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes > 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                }
                lblTimer.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            catch
            {
                MessageBox.Show("Error in timmer");
            }
        }
        //Exit btn
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Close form and call frmMenu.
        private void frmGamePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            try 
            {
                player.Stop();
                main1.Show();
                main1.SPlayer();
            }
            catch
            {
                MessageBox.Show("Error in form closing");
            }
        }
        private void frmGamePicture_Load(object sender, EventArgs e)
        {
            PlayMusic();
        }
        #endregion events
    }
}