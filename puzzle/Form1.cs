using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace puzzle
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            Shuffle(random);
         
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(index < gbxMain.Controls.Count)
                    {
                        buttons[i,j] = (Button) gbxMain.Controls[index];
                        index++;
                    }
                }
            }
            for (int i = 0; i < gbxMain.Controls.Count; i++)
            {
                if (gbxMain.Controls[i].Name != "btn16")
                {
                    gbxMain.Controls[i].Text = $"{numbers[i]}";
                }
            }
        }

        #region variables
        Button[,] buttons = new Button[4, 4];
        int index = 0;
        Random random = new Random();
        List<int> numbers = new List<int>([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15]);
        #endregion variables

        #region events
        private void btnButtons_Click(object sender, EventArgs e)
        {
            ChangeButtons(sender);
        }
        #endregion events

        #region methods

        void ChangeButtons(object sender)
        {
            Button button = (Button)sender;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (button == buttons[i, j])
                    {
                        try
                        {
                            if (buttons[i, j + 1].Text == "")
                            {
                                buttons[i, j + 1].Text = button.Text;
                                button.Text = "";
                            }
                        }
                        catch { }
                        try
                        {
                            if (buttons[i, j - 1].Text == "")
                            {
                                buttons[i, j - 1].Text = button.Text;
                                button.Text = "";
                            }
                        }
                        catch { }
                        try
                        {
                            if (buttons[i + 1, j].Text == "")
                            {
                                buttons[i + 1, j].Text = button.Text;
                                button. Text = "";
                            }
                        }
                        catch { }
                        try
                        {
                            if (buttons[i - 1, j].Text == "")
                            {
                                buttons[i - 1, j].Text = button.Text;
                                button.Text = "";
                            }
                        }
                        catch {}
                    }
                }
            }
        }
        void CheckIfWin()
        {

        }

        void  Shuffle(Random random)
        {
            numbers = numbers.OrderBy(x => random.Next(1,16)).ToList();
            
        }

#endregion methods
    }
}
