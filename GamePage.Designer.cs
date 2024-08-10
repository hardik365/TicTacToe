namespace TicTacToe
{
    partial class GamePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            TopLeft = new PictureBox();
            TopRight = new PictureBox();
            TopCenter = new PictureBox();
            MiddleLeft = new PictureBox();
            MiddleCenter = new PictureBox();
            MiddleRight = new PictureBox();
            BottomLeft = new PictureBox();
            BottomCenter = new PictureBox();
            BottomRight = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TopLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiddleLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiddleCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiddleRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(25, 23);
            ExitButton.Margin = new Padding(5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(153, 46);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit Game";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // TopLeft
            // 
            TopLeft.Location = new Point(311, 55);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(250, 250);
            TopLeft.TabIndex = 1;
            TopLeft.TabStop = false;
            //TopLeft.Click += TopLeft_Click;
            // 
            // TopRight
            // 
            TopRight.Location = new Point(869, 55);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(240, 250);
            TopRight.TabIndex = 2;
            TopRight.TabStop = false;
            // 
            // TopCenter
            // 
            TopCenter.Location = new Point(311, 335);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(250, 234);
            TopCenter.TabIndex = 3;
            TopCenter.TabStop = false;
            // 
            // MiddleLeft
            // 
            MiddleLeft.Location = new Point(600, 55);
            MiddleLeft.Name = "MiddleLeft";
            MiddleLeft.Size = new Size(225, 250);
            MiddleLeft.TabIndex = 4;
            MiddleLeft.TabStop = false;
            // 
            // MiddleCenter
            // 
            MiddleCenter.Location = new Point(600, 335);
            MiddleCenter.Name = "MiddleCenter";
            MiddleCenter.Size = new Size(230, 234);
            MiddleCenter.TabIndex = 5;
            MiddleCenter.TabStop = false;
            // 
            // MiddleRight
            // 
            MiddleRight.Location = new Point(869, 345);
            MiddleRight.Name = "MiddleRight";
            MiddleRight.Size = new Size(240, 224);
            MiddleRight.TabIndex = 6;
            MiddleRight.TabStop = false;
            // 
            // BottomLeft
            // 
            BottomLeft.Location = new Point(311, 613);
            BottomLeft.Name = "BottomLeft";
            BottomLeft.Size = new Size(250, 242);
            BottomLeft.TabIndex = 7;
            BottomLeft.TabStop = false;
            // 
            // BottomCenter
            // 
            BottomCenter.Location = new Point(600, 605);
            BottomCenter.Name = "BottomCenter";
            BottomCenter.Size = new Size(230, 250);
            BottomCenter.TabIndex = 8;
            BottomCenter.TabStop = false;
            // 
            // BottomRight
            // 
            BottomRight.Location = new Point(863, 605);
            BottomRight.Name = "BottomRight";
            BottomRight.Size = new Size(260, 250);
            BottomRight.TabIndex = 9;
            BottomRight.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Canvas1;
            pictureBox1.Location = new Point(311, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 800);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // GamePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1430, 911);
            Controls.Add(BottomRight);
            Controls.Add(BottomCenter);
            Controls.Add(BottomLeft);
            Controls.Add(MiddleRight);
            Controls.Add(MiddleCenter);
            Controls.Add(MiddleLeft);
            Controls.Add(TopCenter);
            Controls.Add(TopRight);
            Controls.Add(TopLeft);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "GamePage";
            Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)TopLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiddleLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiddleCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiddleRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private PictureBox TopLeft;
        private PictureBox TopRight;
        private PictureBox TopCenter;
        private PictureBox MiddleLeft;
        private PictureBox MiddleCenter;
        private PictureBox MiddleRight;
        private PictureBox BottomLeft;
        private PictureBox BottomCenter;
        private PictureBox BottomRight;
        private PictureBox pictureBox1;
    }
}