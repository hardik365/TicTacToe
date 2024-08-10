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
        //keeps track of whose turn it is, x or o
        char turn = 'x';

        string crossPath = "cross.png";
        string circlePath = "circle.png";
        public GamePage()
        {



            InitializeComponent();



            ExitButton.Click += ExitButton_Click;
            TopLeft.Click += TopLeft_Click;
        }

        //I
        private void ExitButton_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide the game form
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.Show(); // Show the main form
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {

            //Image.FromFile(imagePath)
            TopLeft.Image = Image.FromFile(circlePath);
            
        }
    }
}
