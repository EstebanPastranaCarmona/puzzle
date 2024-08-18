using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace puzzle
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            frmMenu Menu = new frmMenu();
            Menu.Close();
            InitializeComponent();
            Shuffle(random);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (index < gbxMain.Controls.Count)
                    {
                        buttons[i, j] = (Button)gbxMain.Controls[index];
                        index++;
                    }
                }
            }
            for (int i = 0; i < gbxMain.Controls.Count; i++)
            {
                if (gbxMain.Controls[i].Name != "btn16")
                {
                    gbxMain.Controls[i].Text = $"{randomNumbers[i]}";
                }
            }
        }
        #region variables
        Button[,] buttons = new Button[4, 4];
        int index = 0;
        Random random = new Random();
        List<int> numbers = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]);
        List<int> randomNumbers = new List<int>();
        #endregion variables

        #region events
        private void btnButtons_Click(object sender, EventArgs e)
        {
            ChangeButtons(sender);
            CheckIfWin();
        }
        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion events

        #region methods
        void ChangeButtons(object sender)
        {
            //The object that invokes the event
            Button clickedButton = (Button)sender;
            //The matrix is ??traversed
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
                    //The text converted to int is added to the list of the order of numbers in the game
                    buttonNumber.Add(Convert.ToInt32(gbxMain.Controls[i].Text));
                }
            }
            //It is checked that the list with the current order of the numbers in the game is equal to the list with the 
            //order that the numbers must have to win
            if (buttonNumber.SequenceEqual(numbers))
            {
                MessageBox.Show("Congratulation you win", "Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next(1, 16)).ToList();
        }

        #endregion methods


    }
}
