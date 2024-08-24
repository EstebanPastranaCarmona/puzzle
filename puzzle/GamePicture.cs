using System.Collections.Generic;
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

                btnMuteGame.Image = unmute;
                btnPauseGame.Image =pause;
                originalPictureBox.Image = Properties.Resources.original;

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
        List<Image> routeOrdered = new List<Image>();
        List<Image> movements = new List<Image>();
        List<int> numbers = new List<int>([0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        private SoundPlayer player;
        private frmMenu main1;

        PictureBox[,] pictures = new PictureBox[4, 4];
        int pictureIndex = 0;

        Image mute = Properties.Resources.mute;
        Image unmute = Properties.Resources.unmute;
        Image play = Properties.Resources.play;
        Image pause = Properties.Resources.pause;
        bool isMusicActive = true;
        bool isGameActive = true;
        
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
                    string resourceName = "_" + i;
                   Image image = (Image) Properties.GamePictureImageResources.ResourceManager.GetObject(resourceName);

                    if(image != null)
                    {
                        routeOrdered.Add(image);
                    }
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
                    pic.Image = movements[index];
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
                List<Image> actualPictures = new List<Image>();
                //The list of groupbox controls is iterated
                for (int i = 0; i < gbxImages.Controls.Count; i++)
                {
                    //The pictureBox is saved in a temporary variable
                    PictureBox temp = (PictureBox)gbxImages.Controls[i];
                    //The address of the image is saved in the list, thus obtaining the order of the images in the matrix
                    actualPictures.Add(temp.Image);
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
                player = new SoundPlayer(Properties.Resources.music33);
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
                    btnPauseGame.Image = play;
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
                    btnPauseGame.Image = pause;
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
                            if (pictures[i, j + 1].Image == movements[15])
                            {
                                var temporary = pictures[i, j + 1].Image;
                                pictures[i, j + 1].Image = pictures[i, j].Image;
                                pictures[i, j].Image = temporary;
                                EndGame();
                            }
                        }
                       catch { }
                        try
                        {
                            if (pictures[i, j - 1].Image == movements[15] )
                            {
                                    var temporary = pictures[i, j - 1].Image;
                                    pictures[i, j - 1].Image = pictures[i, j].Image;
                                    pictures[i, j].Image = temporary;
                                    EndGame();
                            }
                        }
                        catch { }
                        try
                        {
                            if (pictures[i + 1, j].Image == movements[15])
                            {
                                    var temporary = pictures[i + 1, j].Image;
                                    pictures[i + 1, j].Image = pictures[i, j].Image;
                                    pictures[i, j].Image = temporary;
                                    EndGame();
                            }
                        }
                        catch { }
                        try
                        {
                            if (pictures[i - 1, j].Image == movements[15])
                            {
                                    var temporary = pictures[i - 1, j].Image;
                                    pictures[i - 1, j].Image = pictures[i, j].Image;
                                    pictures[i, j].Image = temporary;
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
                    btnMuteGame.Image = mute;
                    player.Stop();
                    isMusicActive = false;
                }
                else if (!isMusicActive && isGameActive)
                {
                    btnMuteGame.Image = unmute;
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