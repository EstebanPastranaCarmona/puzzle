using System.Data;
using System.Media;

namespace puzzle
{
    public partial class frmGamePicture : Form
    {
        private frmMenu main1;

        public frmGamePicture(frmMenu main2)
        {
            InitializeComponent();
            try 
            {
                SPlayer();
                loadList();
                Shuffle(random);
                randomImages();
                loadGame();

                main1 = main2;

                btnMuteGame.Image = Image.FromFile(unmute);
                btnPauseGame.Image = Image.FromFile(pause1);
                originalPictureBox.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\original.jpg";

                tmtTimer.Start();
            }
            catch
            {
                MessageBox.Show("Problem to start game.");
            }
            
        }
        #region variables
        Random random = new Random();
        List<string> routeOrdered = new List<string>();
        List<string> movements = new List<string>();
        List<int> numbers = new List<int>([0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        private SoundPlayer player;

        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        public string play1 = @"C:\Source\Puzzle\puzzle\assets\icon\play.png";
        public string pause1 = @"C:\Source\Puzzle\puzzle\assets\icon\pause.png";
        bool isMusicActive = true;
        private bool isGameActive = true;
        
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int coincidences = 0;
        #endregion variables

        #region methods
        //loadlist is responsible for loading the location of images in the list.
        public void loadList()
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
        public void loadGame()
        {
            try
            {
                int index = 15;
                foreach (PictureBox pic in gbxImages.Controls)
                {
                    pic.ImageLocation = movements[index];
                    index--;
                }
                endGame();
            }
            catch
            {
                MessageBox.Show("Error to load game");
            }
        }
        //loadGame copy items of the routeOrdered list to movement list in random posistions.
        public void randomImages()
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
        public void endGame()
        {
            try
            {
                coincidences = 0;

                for (int i = 0; i < routeOrdered.Count; i++)
                {
                    if (movements[i] == routeOrdered[i])
                    {
                        coincidences = coincidences + 1;
                        if (coincidences == 15)
                        {
                            frmWin win = new frmWin($" {hours:D2}:{minutes:D2}:{seconds:D2}");
                            win.callinForm = this;
                            win.ShowDialog();
                        }
                    }
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
                if (isGameActive)
                {
                    btnPauseGame.Image = Image.FromFile(play1);
                    tmtTimer.Stop();
                    isGameActive = false;
                    player.Stop();
                    frmPause pauseForm = new frmPause();
                    pauseForm.callinForm = this;
                    pauseForm.ShowDialog();
                }
                else
                {
                    btnPauseGame.Image = Image.FromFile(pause1);
                    tmtTimer.Start();
                    player.PlayLooping();
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
        private void exit_Click(object sender, EventArgs e)
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
        private void pic0_Click(object sender, EventArgs e)
        {
            //Down
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[0];
                movements[0] = temporary;
                loadGame();
            }
            //Lefth
            if (movements[1] == routeOrdered[15])
            {
                var temporary = movements[1];
                movements[1] = movements[0];
                movements[0] = temporary;
                loadGame();
            }
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Down
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[1];
                movements[1] = temporary;
                loadGame();
            }
            //Right
            if (movements[0] == routeOrdered[15])
            {
                var temporary = movements[0];
                movements[0] = movements[1];
                movements[1] = temporary;
                loadGame();
            }
            //Lefth
            if (movements[2] == routeOrdered[15])
            {
                var temporary = movements[2];
                movements[2] = movements[1];
                movements[1] = temporary;
                loadGame();
            }
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            //Rigth
            if (movements[1] == routeOrdered[15])
            {
                var temporary = movements[1];
                movements[1] = movements[2];
                movements[2] = temporary;
                loadGame();
            }
            //Lefth
            if (movements[3] == routeOrdered[15])
            {
                var temporary = movements[3];
                movements[3] = movements[2];
                movements[2] = temporary;
                loadGame();
            }
            //Down
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[2];
                movements[2] = temporary;
                loadGame();
            }
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            //Rigth
            if (movements[2] == routeOrdered[15])
            {
                var temporary = movements[2];
                movements[2] = movements[3];
                movements[3] = temporary;
                loadGame();
            }
            //Up
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[3];
                movements[3] = temporary;
                loadGame();
            }
        }
        private void pic4_Click(object sender, EventArgs e)
        {
            //Up
            if (movements[0] == routeOrdered[15])
            {
                var temporary = movements[0];
                movements[0] = movements[4];
                movements[4] = temporary;
                loadGame();
            }
            //Down
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[4];
                movements[4] = temporary;
                loadGame();
            }
            //Rigth
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[5];
                movements[5] = temporary;
                loadGame();
            }
            //Left
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[4];
                movements[4] = temporary;
                loadGame();
            }
        }
        private void pic5_Click(object sender, EventArgs e)
        {
            //Up
            if (movements[1] == routeOrdered[15])
            {
                var temporary = movements[1];
                movements[1] = movements[5];
                movements[5] = temporary;
                loadGame();
            }
            //Down
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[5];
                movements[5] = temporary;
                loadGame();
            }
            //Rgth
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[5];
                movements[5] = temporary;
                loadGame();
            }
            //Left
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[5];
                movements[5] = temporary;
                loadGame();
            }
        }
        private void pic6_Click(object sender, EventArgs e)
        {
            //Rigth
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[6];
                movements[6] = temporary;
                loadGame();
            }
            //Left
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[6];
                movements[6] = temporary;
                loadGame();
            }
            //Down
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[6];
                movements[6] = temporary;
                loadGame();
            }

            //Up
            if (movements[2] == routeOrdered[15])
            {
                var temporary = movements[2];
                movements[2] = movements[6];
                movements[6] = temporary;
                loadGame();
            }
        }
        private void pic7_Click(object sender, EventArgs e)
        {
            //Rigth
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[7];
                movements[7] = temporary;
                loadGame();
            }
            //Up
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[7];
                movements[7] = temporary;
                loadGame();
            }

            //Down
            if (movements[3] == routeOrdered[15])
            {
                var temporary = movements[3];
                movements[3] = movements[7];
                movements[7] = temporary;
                loadGame();
            }
        }
        private void pic8_Click(object sender, EventArgs e)
        {
            //Down
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[8];
                movements[8] = temporary;
                loadGame();
            }
            //Up
            if (movements[12] == routeOrdered[15])
            {
                var temporary = movements[12];
                movements[12] = movements[8];
                movements[8] = temporary;
                loadGame();
            }

            //Left
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[8];
                movements[8] = temporary;
                loadGame();
            }

        }
        private void pic9_Click(object sender, EventArgs e)
        {
            //Down
            if (movements[13] == routeOrdered[15])
            {
                var temporary = movements[13];
                movements[13] = movements[9];
                movements[9] = temporary;
                loadGame();
            }
            //Up
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[9];
                movements[9] = temporary;
                loadGame();
            }
            //Right
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[9];
                movements[9] = temporary;
                loadGame();
            }
            //Left
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[9];
                movements[9] = temporary;
                loadGame();
            }
        }
        private void pic10_Click(object sender, EventArgs e)
        {
            //Down
            if (movements[14] == routeOrdered[15])
            {
                var temporary = movements[14];
                movements[14] = movements[10];
                movements[10] = temporary;
                loadGame();
            }
            //Rigth
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[10];
                movements[10] = temporary;
                loadGame();
            }
            //Left
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[10];
                movements[10] = temporary;
                loadGame();
            }
            //Up
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[10];
                movements[10] = temporary;
                loadGame();
            }

        }
        private void pic11_Click(object sender, EventArgs e)
        {
            //up
            if (movements[15] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[15];
                movements[15] = temporary;
                loadGame();
            }
            //Down
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[11];
                movements[11] = temporary;
                loadGame();
            }
            //Left
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[10];
                movements[10] = temporary;
                loadGame();
            }
        }
        private void pic12_Click(object sender, EventArgs e)
        {
            //Right
            if (movements[13] == routeOrdered[15])
            {
                var temporary = movements[13];
                movements[13] = movements[12];
                movements[12] = temporary;
                loadGame();
            }
            //LEeft
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[11] = movements[10];
                movements[11] = temporary;
                loadGame();
            }
            //Down
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[12];
                movements[12] = temporary;
                loadGame();
            }
        }
        private void pic13_Click(object sender, EventArgs e)
        {
            //Up
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[13];
                movements[13] = temporary;
                loadGame();
            }
            //Right
            if (movements[14] == routeOrdered[15])
            {
                var temporary = movements[14];
                movements[14] = movements[13];
                movements[13] = temporary;
                loadGame();
            }
            //Left
            if (movements[12] == routeOrdered[15])
            {
                var temporary = movements[12];
                movements[12] = movements[13];
                movements[13] = temporary;
                loadGame();
            }
        }
        private void pic14_Click(object sender, EventArgs e)
        {
            //Right
            if (movements[13] == routeOrdered[15])
            {
                var temporary = movements[14];
                movements[14] = movements[13];
                movements[13] = temporary;
                loadGame();
            }
            //Left
            if (movements[15] == routeOrdered[15])
            {
                var temporary = movements[15];
                movements[15] = movements[14];
                movements[14] = temporary;
                loadGame();
            }

            //Up
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[14];
                movements[14] = temporary;
                loadGame();
            }
        }
        private void pic15_Click(object sender, EventArgs e)
        {
            //Left
            if (movements[14] == routeOrdered[15])
            {
                var temporary = movements[14];
                movements[14] = movements[15];
                movements[15] = temporary;
                loadGame();
            }
            //Up
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[15];
                movements[15] = temporary;
                loadGame();
            }
        }
        #endregion events
    }
}