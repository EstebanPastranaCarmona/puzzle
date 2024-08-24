using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class frmWin : Form
    {

        public Form callingForm;

        //Constructor
        public frmWin(string time)
        {
            InitializeComponent();
            lblTime.Text = lblTime.Text + time;
        }
        //Method
        private void btnMenu_Click(object sender, EventArgs e)
        { 
            callingForm.Close();
            callingForm.Dispose();
            this.Close();
        }
    }
}
