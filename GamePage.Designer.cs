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
            Player1Name = new Label();
            Playe2Name = new Label();
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
            ExitButton.Location = new Point(470, 669);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit Game";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // TopLeft
            // 
            TopLeft.Location = new Point(269, 144);
            TopLeft.Margin = new Padding(2);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(154, 156);
            TopLeft.TabIndex = 1;
            TopLeft.TabStop = false;
            // 
            // TopRight
            // 
            TopRight.Location = new Point(613, 144);
            TopRight.Margin = new Padding(2);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(148, 156);
            TopRight.TabIndex = 2;
            TopRight.TabStop = false;
            // 
            // TopCenter
            // 
            TopCenter.Location = new Point(447, 144);
            TopCenter.Margin = new Padding(2);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(142, 156);
            TopCenter.TabIndex = 3;
            TopCenter.TabStop = false;
            // 
            // MiddleLeft
            // 
            MiddleLeft.Location = new Point(269, 319);
            MiddleLeft.Margin = new Padding(2);
            MiddleLeft.Name = "MiddleLeft";
            MiddleLeft.Size = new Size(154, 146);
            MiddleLeft.TabIndex = 4;
            MiddleLeft.TabStop = false;
            // 
            // MiddleCenter
            // 
            MiddleCenter.Location = new Point(447, 319);
            MiddleCenter.Margin = new Padding(2);
            MiddleCenter.Name = "MiddleCenter";
            MiddleCenter.Size = new Size(142, 146);
            MiddleCenter.TabIndex = 5;
            MiddleCenter.TabStop = false;
            // 
            // MiddleRight
            // 
            MiddleRight.Location = new Point(609, 319);
            MiddleRight.Margin = new Padding(2);
            MiddleRight.Name = "MiddleRight";
            MiddleRight.Size = new Size(152, 140);
            MiddleRight.TabIndex = 6;
            MiddleRight.TabStop = false;
            // 
            // BottomLeft
            // 
            BottomLeft.Location = new Point(269, 493);
            BottomLeft.Margin = new Padding(2);
            BottomLeft.Name = "BottomLeft";
            BottomLeft.Size = new Size(154, 151);
            BottomLeft.TabIndex = 7;
            BottomLeft.TabStop = false;
            // 
            // BottomCenter
            // 
            BottomCenter.Location = new Point(447, 488);
            BottomCenter.Margin = new Padding(2);
            BottomCenter.Name = "BottomCenter";
            BottomCenter.Size = new Size(142, 156);
            BottomCenter.TabIndex = 8;
            BottomCenter.TabStop = false;
            // 
            // BottomRight
            // 
            BottomRight.Location = new Point(609, 488);
            BottomRight.Margin = new Padding(2);
            BottomRight.Name = "BottomRight";
            BottomRight.Size = new Size(151, 156);
            BottomRight.TabIndex = 9;
            BottomRight.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Canvas;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(269, 144);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 500);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Player1Name
            // 
            Player1Name.AutoSize = true;
            Player1Name.Font = new Font("Segoe UI", 20F);
            Player1Name.Location = new Point(138, 61);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(235, 46);
            Player1Name.TabIndex = 11;
            Player1Name.Text = "Player 1 Name";
            // 
            // Playe2Name
            // 
            Playe2Name.AutoSize = true;
            Playe2Name.Font = new Font("Segoe UI", 20F);
            Playe2Name.Location = new Point(685, 61);
            Playe2Name.Name = "Playe2Name";
            Playe2Name.Size = new Size(235, 46);
            Playe2Name.TabIndex = 12;
            Playe2Name.Text = "Player 2 Name";
            // 
            // GamePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1055, 772);
            Controls.Add(Playe2Name);
            Controls.Add(Player1Name);
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
            PerformLayout();
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
        private Label Player1Name;
        private Label Playe2Name;
    }
}