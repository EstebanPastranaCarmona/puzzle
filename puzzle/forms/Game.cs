using System.Diagnostics;
using System.Media;
using System.Numerics;

namespace puzzle
{
    public partial class frmGame : Form
    {
        public frmGame(frmMenu main2)
        {
            try
            {
                InitializeComponent();
                SPlayer();
                Shuffle(random);
                AddButtonsToMatriz();
                PutRandomNumbers();

                main1 = main2;
                btnMuteGame.Image = Properties.Resources.unmute;
                btnPauseGame.Image = Properties.Resources.pause;

                tmtTimer.Start();
            } 
            catch( Exception ex)
            {
                MessageBox.Show($"There was an error loading the game, the application will restart Details: {ex.Message}", "Error");
                string exePath = Application.ExecutablePath;
                Process.Start(exePath);
                Application.Exit();
            }
        }
        #region variables

        private bool isMusicActive = true;
        private bool isGameActive = true;
        private frmMenu main1;
        public SoundPlayer player;
        Random random = new Random();
        Button[,] buttons = new Button[4, 4];
        List<int> numbers = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]);
        List<int> randomNumbers = new List<int>();

        int buttonIndex = 0;
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        #endregion variables

        #region methods
        void AddButtonsToMatriz()
        {
            //The buttons in the groupbox are added to the matrix
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (buttonIndex < gbxMain.Controls.Count)
                    {
                        buttons[i, j] = (Button)gbxMain.Controls[buttonIndex];
                        buttonIndex++;
                    }
                }
            }
        }
        void PutRandomNumbers() 
        {
            //Random numbers are assigned to the buttons.
            for (int i = 0; i < gbxMain.Controls.Count; i++)
            {
                if (gbxMain.Controls[i].Name != "btn16")
                {
                    gbxMain.Controls[i].Text = $"{randomNumbers[i]}";
                }
            }
        }
        void ChangeButtons(object sender)
        {
            //The object that invokes the event
            Button clickedButton = (Button)sender;
            // if pause button if no active
            if (isGameActive)
            //The matrix is traversed
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        //The button that invokes the event is searched within the matrix.
                        if (clickedButton == buttons[i, j])
                        {
                            //Searching for a button with adjacent white space
                            try
                            {
                                //check right
                                if (buttons[i, j + 1].Text == "")
                                {
                                    buttons[i, j + 1].Text = clickedButton.Text;
                                    clickedButton.Text = "";
                                }
                            }
                            catch { }
                            try
                            {
                                //check left
                                if (buttons[i, j - 1].Text == "")
                                {
                                    buttons[i, j - 1].Text = clickedButton.Text;
                                    clickedButton.Text = "";
                                }
                            }
                            catch { }
                            try
                            {
                                //check below
                                if (buttons[i + 1, j].Text == "")
                                {
                                    buttons[i + 1, j].Text = clickedButton.Text;
                                    clickedButton.Text = "";
                                }
                            }
                            catch { }
                            try
                            {
                                //check above
                                if (buttons[i - 1, j].Text == "")
                                {
                                    buttons[i - 1, j].Text = clickedButton.Text;
                                    clickedButton.Text = "";
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
        }
        void CheckIfWin()
        {
            //List with the order of the numbers in the game
            List<int> buttonNumber = new List<int>();

            //The groupbox where the buttons are is iterated.
            for (int i = 0; i < gbxMain.Controls.Count - 1; i++)
            {
                //Check that the button text is not empty
                if (!string.IsNullOrEmpty(gbxMain.Controls[i].Text))
                {
                    //The text converted to int is added to the list of the order of numbers in the
                    //game
                    buttonNumber.Add(Convert.ToInt32(gbxMain.Controls[i].Text));
                }
            }
            //It is checked that the list with the current order of the numbers in the game is equal to the list
            //with the order that the numbers must have to win
            if (buttonNumber.SequenceEqual(numbers))
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
        //Method that fills a list with random numbers from 1 to 15
        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next(1, 16)).ToList();
        }
        //method that plays music
        public void SPlayer()
        {
            player = new SoundPlayer(Properties.Resources.music11);
            
            player.PlayLooping();
        }
        public void PauseGame()
        {
            try
            {
                //Check that the game is active
                if (isGameActive)
                {
                    //The image of the pause button is changed
                    btnPauseGame.Image = Properties.Resources.play;
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
                    btnPauseGame.Image = Properties.Resources.pause;
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
        private void btnButtons_Click(object sender, EventArgs e)
        {
            ChangeButtons(sender);
            CheckIfWin();
        }
        //event to mute the game
        private void btnMuteGame_Click_1(object sender, EventArgs e)
        {
            //It is checked that the music is active and the game is not paused
            if (isMusicActive && isGameActive)
            {
                btnMuteGame.Image = Properties.Resources.mute;
                player.Stop();
                isMusicActive = false;
            }
            //It is checked that the music is disable and the game is not paused
            else if (!isMusicActive && isGameActive) 
            {
                btnMuteGame.Image = Properties.Resources.unmute;
                player.PlayLooping();
                isMusicActive = true;
            }
        }
        //Event for the stopwatch
        private void tmCronometer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
                if (minutes >= 60)
                {
                    minutes = 0;
                    hours++;
                }
            }
            lblTimer.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
        //Event to pause the game
        private void btnPauseGame_Click(object sender, EventArgs e)
        {
           PauseGame();
        }
        //Event for when the form is closed
        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //the music stops
            player.Stop();
            //the form of the menu is shown
            main1.Show();
            //the menu music starts
            main1.SPlayer();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion events
    }
}
