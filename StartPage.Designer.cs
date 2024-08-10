namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            Player1Box = new TextBox();
            Player2Box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(323, 349);
            StartButton.Margin = new Padding(5, 5, 5, 5);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(153, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start Game";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // Player1Box
            // 
            Player1Box.Location = new Point(299, 195);
            Player1Box.Margin = new Padding(5, 5, 5, 5);
            Player1Box.Name = "Player1Box";
            Player1Box.Size = new Size(201, 39);
            Player1Box.TabIndex = 1;
            // 
            // Player2Box
            // 
            Player2Box.Location = new Point(299, 296);
            Player2Box.Margin = new Padding(5, 5, 5, 5);
            Player2Box.Name = "Player2Box";
            Player2Box.Size = new Size(201, 39);
            Player2Box.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(72, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(654, 72);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Tic-Tac-Toe!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 158);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(236, 32);
            label2.TabIndex = 4;
            label2.Text = "Enter Player 1 Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 259);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 5;
            label3.Text = "Enter Player 2 Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(798, 552);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Player2Box);
            Controls.Add(Player1Box);
            Controls.Add(StartButton);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private TextBox Player1Box;
        private TextBox Player2Box;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
