﻿using System;
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
        //keeps track of whose turn it is, O or X (0 or 1)
        private int turn = 0;
        

        //path to our images
        private string crossPath = "cross.png";
        private string circlePath = "circle.png";

        //will keep logic of the board
        private int[,] grid = new int[3, 3];


        //Keep track of the wins
        private int player1Wins = 0;
        private int player2Wins = 0;
        public GamePage()
        {
            //initialize the contents
            InitializeComponent();
            fillGrid();
            //showGrid(); 

            //Show the player names
            Player1Name.Text = Form1.Player1Name;
            Player2Name.Text = Form1.Player2Name;
            turnLabel.Text = Player1Name.Text + "'s turn";

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


        //fill the grid with 9s to represent empty spaces
        public void fillGrid()
        {
            //fill the grid with 9s
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    grid[i, j] = 9;
            }
        }

        //This is for debugging purposes
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

        //For each of the buttons, we will have a click event
        private void TopLeft_Click(object sender, EventArgs e)
        {
            //depending on whose turn it will set it differently
            if (turn == 1)
            {
                TopLeft.Image = Image.FromFile(crossPath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 1;
                turn = 0;
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else //turn == 0
            {
                TopLeft.Image = Image.FromFile(circlePath);
                TopLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 0] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                TopCenter.Image = Image.FromFile(circlePath);
                TopCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 1] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
            TopCenter.Enabled = false;//so you can't click again
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                TopRight.Image = Image.FromFile(circlePath);
                TopRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[0, 2] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                MiddleLeft.Image = Image.FromFile(circlePath);
                MiddleLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 0] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                MiddleCenter.Image = Image.FromFile(circlePath);
                MiddleCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 1] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                MiddleRight.Image = Image.FromFile(circlePath);
                MiddleRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[1, 2] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                BottomLeft.Image = Image.FromFile(circlePath);
                BottomLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 0] = 0;
                turn = 1;
                ;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                BottomCenter.Image = Image.FromFile(circlePath);
                BottomCenter.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 1] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
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
                turnLabel.Text = Player1Name.Text + "'s turn";
            }
            else
            {
                BottomRight.Image = Image.FromFile(circlePath);
                BottomRight.SizeMode = PictureBoxSizeMode.StretchImage;
                grid[2, 2] = 0;
                turn = 1;
                turnLabel.Text = Player2Name.Text + "'s turn";
            }
            checkWin();
            BottomRight.Enabled = false;//so you can't click again   
            //showGrid();
        }



        //To see if we have a winner or not
        private void checkWin()
        {
            if (grid[0, 0] == 0 && grid[0, 1] == 0 && grid[0, 2] == 0)      //  0|0|0
            {                                                               //   | |
                MessageBox.Show("Player 1 wins!");                          //   | |
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[1, 0] == 0 && grid[1, 1] == 0 && grid[1, 2] == 0) //  | |
            {                                                               // 0|0|0
                MessageBox.Show("Player 1 wins!");                          //  | |
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[2, 0] == 0 && grid[2, 1] == 0 && grid[2, 2] == 0) //  | |
            {                                                               //  | |
                MessageBox.Show("Player 1 wins!");                          // 0|0|0
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 0] == 0 && grid[1, 1] == 0 && grid[2, 2] == 0) // 0| |
            {                                                               //  |0|
                MessageBox.Show("Player 1 wins!");                          //  | |0
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 2] == 0 && grid[1, 1] == 0 && grid[2, 0] == 0) //  | |0
            {                                                               //  |0|
                MessageBox.Show("Player 1 wins!");                          // 0| |
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 0] == 0 && grid[1, 0] == 0 && grid[2, 0] == 0) // 0| |
            {                                                               // 0| |
                MessageBox.Show("Player 1 wins!");                          // 0| |
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 1] == 0 && grid[1, 1] == 0 && grid[2, 1] == 0) //  |0|
            {                                                               //  |0|
                MessageBox.Show("Player 1 wins!");                          //  |0|
                player1Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 2] == 0 && grid[1, 2] == 0 && grid[2, 2] == 0) //  | |0
            {                                                               //  | |0
                MessageBox.Show("Player 1 wins!");                          //  | |0
                player1Wins++;
                Clear.PerformClick();
            }


            else if (grid[0, 0] == 1 && grid[0, 1] == 1 && grid[0, 2] == 1) //  X|X|X
            {                                                               //   | |
                MessageBox.Show("Player 2 wins!");                          //   | |
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[1, 0] == 1 && grid[1, 1] == 1 && grid[1, 2] == 1) //  | |
            {                                                               // X|X|X
                MessageBox.Show("Player 2 wins!");                          //  | |
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[2, 0] == 1 && grid[2, 1] == 1 && grid[2, 2] == 1) //  | |
            {                                                               //  | |
                MessageBox.Show("Player 2 wins!");                          // X|X|X
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 0] == 1 && grid[1, 1] == 1 && grid[2, 2] == 1) // X| |
            {                                                               //  |X|
                MessageBox.Show("Player 2 wins!");                          //  | |X
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 1) //  | |X
            {                                                               //  |X|
                MessageBox.Show("Player 2 wins!");                          // X| |
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 0] == 1 && grid[1, 0] == 1 && grid[2, 0] == 1) // X| |
            {                                                               // X| |
                MessageBox.Show("Player 2 wins!");                          // X| |
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 1] == 1 && grid[1, 1] == 1 && grid[2, 1] == 1) //  |X|
            {                                                               //  |X|
                MessageBox.Show("Player 2 wins!");                          //  |X|
                player2Wins++;
                Clear.PerformClick();
            }
            else if (grid[0, 2] == 1 && grid[1, 2] == 1 && grid[2, 2] == 1) //  | |X
            {                                                               //  | |X
                MessageBox.Show("Player 2 wins!");                          //  | |X
                player2Wins++;
                Clear.PerformClick();
            }

            if (grid[0, 0] != 9 && grid[0, 1] != 9 && grid[0, 2] != 9 && grid[1, 0] != 9 && grid[1, 1] != 9 && grid[1, 2] != 9 && grid[2, 0] != 9 && grid[2, 1] != 9 && grid[2, 2] != 9)
            {
                MessageBox.Show("It's a tie!");
                Clear.PerformClick();
            }

            p1wins.Text = player1Wins.ToString() + " wins";
            p2wins.Text = player2Wins.ToString() +  " wins";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //clear the grid
            TopLeft.Image = null;
            TopCenter.Image = null;
            TopRight.Image = null;

            MiddleLeft.Image = null;
            MiddleCenter.Image = null;
            MiddleRight.Image = null;

            BottomLeft.Image = null;
            BottomCenter.Image = null;
            BottomRight.Image = null;

            fillGrid();

            //enable the buttons
            TopLeft.Enabled = true;
            TopCenter.Enabled = true;
            TopRight.Enabled = true;

            MiddleLeft.Enabled = true;
            MiddleCenter.Enabled = true;
            MiddleRight.Enabled = true;

            BottomLeft.Enabled = true;
            BottomCenter.Enabled = true;
            BottomRight.Enabled = true;

        }
    }


}
