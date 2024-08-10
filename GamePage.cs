using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GamePage : Form
    {
        public GamePage()
        {



            InitializeComponent();

            ExitButton.Click += ExitButton_Click;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide the game form
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.Show(); // Show the main form
        }
    }
}
