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
            //initialize the contents
            InitializeComponent();
            fillGrid();
            //showGrid(); 

            //Player1Name.Image

            //gameclicks
            TopLeft.Click += TopLeft_Click;
            TopCenter.Click += TopCenter_Click;
            TopRight.Click += TopRight_Click;

            MiddleLeft.Click += MiddleLeft_Click;
            MiddleCenter.Click += MiddleCenter_Click;   
            MiddleRight.Click += MiddleRight_Click;

            BottomLeft.Click += BottomLeft_Click;
            BottomCenter.Click += BottomCenter_Click;
            BottomRight.Click += BottomRight_Click;
                


            ExitButton.Click += ExitButton_Click;
        }

        public void fillGrid()
        {
            //fill the grid with 9s
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    grid[i, j] = 9;
            }


        }   

        public void showGrid()
        {
            //show the grid
            string gridString = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    gridString += grid[i, j] + " ";
                gridString += "\n";
            }
            MessageBox.Show(gridString);
        }


        //Incase they want to exit the game
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
                turn = 0;
            }
            else
            {
                TopLeft.Image = Image.FromFile(circlePath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 0;
                turn = 1;
            }
            TopLeft.Enabled = false;//so you can't click again   
        }


        private void TopCenter_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                TopCenter.Image = Image.FromFile(crossPath);
                TopCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 1] = 1;
                turn = 0;
            }
            else
            {
                TopCenter.Image = Image.FromFile(circlePath);
                TopCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 1] = 0;
                turn = 1;
            }

            TopLeft.Enabled = false;//so you can't click again
            //showGrid();
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                TopRight.Image = Image.FromFile(crossPath);
                TopRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 2] = 1;
                turn = 0;
            }
            else
            {
                TopRight.Image = Image.FromFile(circlePath);
                TopRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 2] = 0;
                turn = 1;
            }

            TopRight.Enabled = false;//so you can't click again   
            //showGrid();
        }
        
        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                MiddleLeft.Image = Image.FromFile(crossPath);
                MiddleLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 0] = 1;
                turn = 0;
            }
            else
            {
                MiddleLeft.Image = Image.FromFile(circlePath);
                MiddleLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 0] = 0;
                turn = 1;
            }

            MiddleLeft.Enabled = false;//so you can't click again   
            //showGrid();
        }

        private void MiddleCenter_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                MiddleCenter.Image = Image.FromFile(crossPath);
                MiddleCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 1] = 1;
                turn = 0;
            }
            else
            {
                MiddleCenter.Image = Image.FromFile(circlePath);
                MiddleCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 1] = 0;
                turn = 1;
            }

            MiddleCenter.Enabled = false;//so you can't click again   
            //showGrid();
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                MiddleRight.Image = Image.FromFile(crossPath);
                MiddleRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 2] = 1;
                turn = 0;
            }
            else
            {
                MiddleRight.Image = Image.FromFile(circlePath);
                MiddleRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 2] = 0;
                turn = 1;
            }

            MiddleRight.Enabled = false;//so you can't click again   
            //showGrid();
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                BottomLeft.Image = Image.FromFile(crossPath);
                BottomLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 0] = 1;
                turn = 0;
            }
            else
            {
                BottomLeft.Image = Image.FromFile(circlePath);
                BottomLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 0] = 0;
                turn = 1;
            }

            BottomLeft.Enabled = false;//so you can't click again   
            //showGrid();
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                BottomCenter.Image = Image.FromFile(crossPath);
                BottomCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 1] = 1;
                turn = 0;
            }
            else
            {
                BottomCenter.Image = Image.FromFile(circlePath);
                BottomCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 1] = 0;
                turn = 1;
            }

            BottomCenter.Enabled = false;//so you can't click again   
            //showGrid();
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                BottomRight.Image = Image.FromFile(crossPath);
                BottomRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 2] = 1;
                turn = 0;
            }
            else
            {
                BottomRight.Image = Image.FromFile(circlePath);
                BottomRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 2] = 0;
                turn = 1;
            }

            BottomRight.Enabled = false;//so you can't click again   
            //showGrid();
        }
    }
}
