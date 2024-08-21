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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace puzzle
{
    public partial class frmGamePicture : Form
    {
        private frmMenu main1;

        public frmGamePicture(frmMenu main2)
        {
            InitializeComponent();
            SPlayer();
            chargeList();
            Shuffle(random);
            randomImages();
            chargeGame();

            main1 = main2;

            btnMuteGame.Image = Image.FromFile(unmute);
            btnPauseGame.Image = Image.FromFile(pause1);
            originalPictureBox.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\original.jpg";

            tmtTimer.Start();
        }
        #region variables
        Random random = new Random();
        List<string> routeOrdered = new List<string>();
        List<string> movements = new List<string>();
        List<int> numbers = new List<int>([0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        int coincidences = 0;
        string mute = @"C:\Source\Puzzle\puzzle\assets\icon\mute.png";
        string unmute = @"C:\Source\Puzzle\puzzle\assets\icon\unmute.png";
        public string play1 = @"C:\Source\Puzzle\puzzle\assets\icon\play.png";
        public string pause1 = @"C:\Source\Puzzle\puzzle\assets\icon\pause.png";
        bool active = true;
        private SoundPlayer player;
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        private bool active2 = true;
        #endregion variables

        #region methods
        public void chargeList()
        {
            for(int i = 0; i <= 15; i++)
            {
                routeOrdered.Add($@"C:\Source\Puzzle\puzzle\assets\img\{i}.jpg");
            }
            
        }
        public void chargeGame()
        {
            int index = 15;
            foreach(PictureBox pic in gbxImages.Controls)
            {
                pic.ImageLocation = movements[index];
                index--;
            }
            endGame();
        }
        public void randomImages()
        {
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                    var pos = randomNumbers[i];
                    movements.Add(routeOrdered[pos]);
            }
            movements.Add(routeOrdered[15]);
        }
        public void endGame()
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
            // MessageBox.Show(String.Format("Coincidencias:{0}",coincidencias),"Puntaje");
        }
        //Music player 
        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music33.wav";
            player.Play();
        }
        //Play music
        public void playMusic()
        {
            if (active)
            {
                player.Play();
            }
        }
    //Shufle position 
        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next()).ToList();
        }
        #endregion methods

        #region events
        private void pic0_Click(object sender, EventArgs e)
        {
            //Up
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[0];
                movements[0] = temporary;
                chargeGame();
            }
            //Down
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[4];
                movements[4] = temporary;
                chargeGame();
            }
            //Lefth
            if (movements[1] == routeOrdered[15])
            {
                var temporary = movements[1];
                movements[1] = movements[0];
                movements[0] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Right
            if (movements[0] == routeOrdered[15])
            {
                var temporary = movements[0];
                movements[0] = movements[1];
                movements[1] = temporary;
                chargeGame();
            }
            //Lefth
            if (movements[2] == routeOrdered[15])
            {
                var temporary = movements[2];
                movements[2] = movements[1];
                movements[1] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Lefth
            if (movements[3] == routeOrdered[15])
            {
                var temporary = movements[3];
                movements[3] = movements[2];
                movements[2] = temporary;
                chargeGame();
            }
            //Down
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[2];
                movements[2] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Up
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[3];
                movements[3] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Down
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[4];
                movements[4] = temporary;
                chargeGame();
            }
            //Rigth
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[5];
                movements[5] = temporary;
                chargeGame();
            }
            //Left
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[4];
                movements[4] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Down
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[5];
                movements[5] = temporary;
                chargeGame();
            }
            //Rgth
            if (movements[4] == routeOrdered[15])
            {
                var temporary = movements[4];
                movements[4] = movements[5];
                movements[5] = temporary;
                chargeGame();
            }
            //Left
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[5];
                movements[5] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Left
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[6];
                movements[6] = temporary;
                chargeGame();
            }
            //Down
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[6];
                movements[6] = temporary;
                chargeGame();
            }

            //Up
            if (movements[2] == routeOrdered[15])
            {
                var temporary = movements[2];
                movements[2] = movements[6];
                movements[6] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Up
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[7];
                movements[7] = temporary;
                chargeGame();
            }

            //Down
            if (movements[3] == routeOrdered[15])
            {
                var temporary = movements[3];
                movements[3] = movements[7];
                movements[7] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Up
            if (movements[12] == routeOrdered[15])
            {
                var temporary = movements[12];
                movements[12] = movements[8];
                movements[8] = temporary;
                chargeGame();
            }

            //Left
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[8];
                movements[8] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Up
            if (movements[5] == routeOrdered[15])
            {
                var temporary = movements[5];
                movements[5] = movements[9];
                movements[9] = temporary;
                chargeGame();
            }
            //Right
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[9];
                movements[9] = temporary;
                chargeGame();
            }
            //Left
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[9];
                movements[9] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Rigth
            if (movements[9] == routeOrdered[15])
            {
                var temporary = movements[9];
                movements[9] = movements[10];
                movements[10] = temporary;
                chargeGame();
            }
            //Left
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[10];
                movements[10] = temporary;
                chargeGame();
            }
            //Up
            if (movements[6] == routeOrdered[15])
            {
                var temporary = movements[6];
                movements[6] = movements[10];
                movements[10] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Down
            if (movements[7] == routeOrdered[15])
            {
                var temporary = movements[7];
                movements[7] = movements[11];
                movements[11] = temporary;
                chargeGame();
            }
            //Left
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[10];
                movements[10] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //LEeft
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[11] = movements[10];
                movements[11] = temporary;
                chargeGame();
            }
            //Down
            if (movements[8] == routeOrdered[15])
            {
                var temporary = movements[8];
                movements[8] = movements[12];
                movements[12] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Right
            if (movements[14] == routeOrdered[15])
            {
                var temporary = movements[14];
                movements[14] = movements[13];
                movements[13] = temporary;
                chargeGame();
            }
            //Left
            if (movements[12] == routeOrdered[15])
            {
                var temporary = movements[12];
                movements[12] = movements[13];
                movements[13] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Left
            if (movements[15] == routeOrdered[15])
            {
                var temporary = movements[15];
                movements[15] = movements[14];
                movements[14] = temporary;
                chargeGame();
            }

            //Up
            if (movements[10] == routeOrdered[15])
            {
                var temporary = movements[10];
                movements[10] = movements[14];
                movements[14] = temporary;
                chargeGame();
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
                chargeGame();
            }
            //Up
            if (movements[11] == routeOrdered[15])
            {
                var temporary = movements[11];
                movements[11] = movements[15];
                movements[15] = temporary;
                chargeGame();
            }
        }
        //Mute and unmute music.
        private void btnMuteGame_Click(object sender, EventArgs e)
        {
            if (active)
            {
                btnMuteGame.Image = Image.FromFile(mute);
                player.Stop();
                active = false;
            }
            else
            {
                btnMuteGame.Image = Image.FromFile(unmute);
                player.Play();
                active = true;
            }
        }
        //Pause and play menu.
        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            if (active2)
            {
                btnPauseGame.Image = Image.FromFile(play1);
                tmtTimer.Stop();
                active2 = false;
            }
            else
            {
                btnPauseGame.Image = Image.FromFile(pause1);
                tmtTimer.Start();
                active2 = true;
            }
        }
        //Timmer of player.
        private void tmtTimer_Tick(object sender, EventArgs e)
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
        //Exit btn
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Close form and call frmMenu.
        private void gamePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            main1.Show();
            main1.SPlayer();
        }
        private void gamePicture_Load(object sender, EventArgs e)
        {
            playMusic();
        }
        #endregion events

    }
}