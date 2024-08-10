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

namespace TicTacToe
{
    public partial class GamePage : Form
    {
        //keeps track of whose turn it is, o or x (0 or 1)
        private int turn = 0;

        //path to our images
        private string crossPath = "cross.png";
        private string circlePath = "circle.png";

        //will keep logic of the board
        private int[,] grid = new int[3,3];

        private int player1Wins = 0;
        private int player2Wins = 0;
        public GamePage()
        {

            InitializeComponent();

            ExitButton.Click += ExitButton_Click;

            //gameclicks
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
            //depending on whose turn it will set it differently
            if(turn == 1)
            {
                TopLeft.Image = Image.FromFile(crossPath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 1;
                turn = 'o';
            }
            else
            {
                TopLeft.Image = Image.FromFile(circlePath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 0;
                turn = 'x';
            }
            TopLeft.Enabled = false;//so you can't click again   
        }


        private void TopCenter_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                TopLeft.Image = Image.FromFile(crossPath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 1;
                turn = 'o';
            }
            else
            {
                TopLeft.Image = Image.FromFile(circlePath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 0;
                turn = 'x';
            }
            TopLeft.Enabled = false;//so you can't click again   
        }
    }
}
