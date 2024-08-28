//Hardik Shahu Copyright 2024

using System;
using System.Windows.Forms;



namespace TicTacToe
{
    public partial class Form1 : Form
    {   // Will keep track of the player names
        public static string Player1Name = "player 1";
        public static string Player2Name = "player 1";

        public GamePage gameBoard;

        public Form1()
        {
            InitializeComponent();

            StartButton.Click += btnStartGame_Click;
        }

        // StartButton_Click
        private void btnStartGame_Click(object sender, EventArgs e) 
       
        {
            Player1Name = Player1Box.Text;
            Player2Name = Player2Box.Text;

            if (string.IsNullOrWhiteSpace(Player1Name) || string.IsNullOrWhiteSpace(Player2Name))
            {
                MessageBox.Show("Please enter both players' names.");
                return;
            }
            else {


                if (gameBoard == null || gameBoard.IsDisposed)
                {
                    gameBoard = new GamePage();
                    gameBoard.FormClosed += GameBoard_Closed;
                }


                this.Hide();
     
                gameBoard.Show();
            }

            //MessageBox.Show($"Player 1: {Player1Name} \nPlayer 2: {Player2Name}");

            
        }

        private void GameBoard_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Show the player entry form when the game form is closed
        }

    }
}
