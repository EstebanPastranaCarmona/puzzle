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
            main1 = main2;
            SPlayer();
            btnMuteGame.Image = Image.FromFile(unmute);
            chargeList();

            Shuffle(random);
            randomImages();
            chargeGame();
            originalPictureBox.ImageLocation = @"C:\Source\Puzzle\puzzle\assets\img\original.jpg";
            tmtTimer.Start();
            btnPauseGame.Image = Image.FromFile(pause1);
        }
        #region variables
        Random random = new Random();
        List<string> rutaOrdenadas = new List<string>();
        List<string> movimientos = new List<string>();
        List<int> numbers = new List<int>([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        int coincidencias = 0;
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
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\00.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\10.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\20.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\30.jpg");

            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\01.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\11.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\21.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\31.jpg");

            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\02.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\12.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\22.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\32.jpg");

            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\03.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\13.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\23.jpg");
            rutaOrdenadas.Add(@"C:\Source\Puzzle\puzzle\assets\img\33.jpg");
        }

        public void chargeGame()
        {
            pic0.ImageLocation = movimientos[0];
            pic1.ImageLocation = movimientos[1];
            pic2.ImageLocation = movimientos[2];
            pic3.ImageLocation = movimientos[3];

            pic4.ImageLocation = movimientos[4];
            pic5.ImageLocation = movimientos[5];
            pic6.ImageLocation = movimientos[6];
            pic7.ImageLocation = movimientos[7];

            pic8.ImageLocation = movimientos[8];
            pic9.ImageLocation = movimientos[9];
            pic10.ImageLocation = movimientos[10];
            pic11.ImageLocation = movimientos[11];

            pic12.ImageLocation = movimientos[12];
            pic13.ImageLocation = movimientos[13];
            pic14.ImageLocation = movimientos[14];
            pic15.ImageLocation = movimientos[15];
            endGame();
        }
        public void randomImages()
        {
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                var pos = randomNumbers[i];
                movimientos.Add(rutaOrdenadas[pos]);
            }
            movimientos.Add(rutaOrdenadas[15]);
        }
        public void endGame()
        {
            coincidencias = 0;

            for (int i = 0; i < rutaOrdenadas.Count; i++)
            {
                if (movimientos[i] == rutaOrdenadas[i])
                {
                    coincidencias = coincidencias + 1;
                    if (coincidencias == 15)
                    {
                        MessageBox.Show("Ha Ganado!!!!", "Felicitaciones");
                    }
                }

            }
            // MessageBox.Show(String.Format("Coincidencias:{0}",coincidencias),"Puntaje");
        }
        public void SPlayer()
        {
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Source\puzzle\puzzle\assets\audio\music33.wav";
            player.Play();
        }
        public void playMusic()
        {
            if (active)
            {
                player.Play();
            }
        }
        #endregion methods

        #region events
        private void pic0_Click(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[0];
                movimientos[0] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[0];
                movimientos[0] = temporal;
                chargeGame();
            }
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[0] == rutaOrdenadas[15])
            {
                var temporal = movimientos[0];
                movimientos[0] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[3] == rutaOrdenadas[15])
            {
                var temporal = movimientos[3];
                movimientos[3] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[3];
                movimientos[3] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[3];
                movimientos[3] = temporal;
                chargeGame();
            }
        }
        private void pic4_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[0] == rutaOrdenadas[15])
            {
                var temporal = movimientos[0];
                movimientos[0] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }
        }
        private void pic5_Click(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
        }
        private void pic6_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }
        }
        private void pic7_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }

            //Abajo
            if (movimientos[3] == rutaOrdenadas[15])
            {
                var temporal = movimientos[3];
                movimientos[3] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }
        }
        private void pic8_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[12] == rutaOrdenadas[15])
            {
                var temporal = movimientos[12];
                movimientos[12] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }

            //Izquierda
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }

        }
        private void pic9_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[13];
                movimientos[13] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
        }
        private void pic10_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }

        }
        private void pic11_Click(object sender, EventArgs e)
        {
            //Ariba
            if (movimientos[15] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[11];
                movimientos[11] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }
        }
        private void pic12_Click(object sender, EventArgs e)
        {
            //derecha
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[13];
                movimientos[13] = movimientos[12];
                movimientos[12] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[11] = movimientos[10];
                movimientos[11] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[12];
                movimientos[12] = temporal;
                chargeGame();
            }
        }
        private void pic13_Click(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[12] == rutaOrdenadas[15])
            {
                var temporal = movimientos[12];
                movimientos[12] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
        }
        private void pic14_Click(object sender, EventArgs e)
        {
            //derecha
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[15] == rutaOrdenadas[15])
            {
                var temporal = movimientos[15];
                movimientos[15] = movimientos[14];
                movimientos[14] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[14];
                movimientos[14] = temporal;
                chargeGame();
            }
        }
        private void pic15_Click(object sender, EventArgs e)
        {
            //Izquieda
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }
        }
        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next()).ToList();
        }
        private void gamePicture_Load(object sender, EventArgs e)
        {
            playMusic();
        }
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
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gamePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            main1.Show();
            main1.SPlayer();
        }
        #endregion events

    }
}