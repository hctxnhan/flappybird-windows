namespace FlappyBird
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.birdSprite = new System.Windows.Forms.PictureBox();
            this.groundSprite = new System.Windows.Forms.PictureBox();
            this.upPipeSprite = new System.Windows.Forms.PictureBox();
            this.downPipeSprite = new System.Windows.Forms.PictureBox();
            this.upPipeSprite2 = new System.Windows.Forms.PictureBox();
            this.downPipeSprite2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.initialChimneys = new System.Windows.Forms.Label();
            this.startMove = new System.Windows.Forms.Label();
            this.jumpButton = new System.Windows.Forms.PictureBox();
            this.playGameButton = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameTutorial = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.yourScoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipeSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipeSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipeSprite2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipeSprite2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGameButton)).BeginInit();
            this.SuspendLayout();
            // 
            // birdSprite
            // 
            this.birdSprite.BackColor = System.Drawing.Color.Transparent;
            this.birdSprite.Image = ((System.Drawing.Image)(resources.GetObject("birdSprite.Image")));
            this.birdSprite.Location = new System.Drawing.Point(129, 272);
            this.birdSprite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birdSprite.Name = "birdSprite";
            this.birdSprite.Size = new System.Drawing.Size(59, 47);
            this.birdSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdSprite.TabIndex = 0;
            this.birdSprite.TabStop = false;
            // 
            // groundSprite
            // 
            this.groundSprite.Image = ((System.Drawing.Image)(resources.GetObject("groundSprite.Image")));
            this.groundSprite.Location = new System.Drawing.Point(-27, 615);
            this.groundSprite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groundSprite.Name = "groundSprite";
            this.groundSprite.Size = new System.Drawing.Size(853, 105);
            this.groundSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundSprite.TabIndex = 1;
            this.groundSprite.TabStop = false;
            // 
            // upPipeSprite
            // 
            this.upPipeSprite.BackColor = System.Drawing.Color.Transparent;
            this.upPipeSprite.Image = global::FlappyBird.Properties.Resources.pipe_up_e1529716823406;
            this.upPipeSprite.Location = new System.Drawing.Point(235, 459);
            this.upPipeSprite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upPipeSprite.Name = "upPipeSprite";
            this.upPipeSprite.Size = new System.Drawing.Size(70, 533);
            this.upPipeSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipeSprite.TabIndex = 2;
            this.upPipeSprite.TabStop = false;
            // 
            // downPipeSprite
            // 
            this.downPipeSprite.BackColor = System.Drawing.Color.Transparent;
            this.downPipeSprite.Image = ((System.Drawing.Image)(resources.GetObject("downPipeSprite.Image")));
            this.downPipeSprite.Location = new System.Drawing.Point(235, -111);
            this.downPipeSprite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downPipeSprite.Name = "downPipeSprite";
            this.downPipeSprite.Size = new System.Drawing.Size(70, 533);
            this.downPipeSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipeSprite.TabIndex = 3;
            this.downPipeSprite.TabStop = false;
            // 
            // upPipeSprite2
            // 
            this.upPipeSprite2.BackColor = System.Drawing.Color.Transparent;
            this.upPipeSprite2.Image = global::FlappyBird.Properties.Resources.pipe_up_e1529716823406;
            this.upPipeSprite2.Location = new System.Drawing.Point(53, 459);
            this.upPipeSprite2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upPipeSprite2.Name = "upPipeSprite2";
            this.upPipeSprite2.Size = new System.Drawing.Size(70, 533);
            this.upPipeSprite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipeSprite2.TabIndex = 4;
            this.upPipeSprite2.TabStop = false;
            // 
            // downPipeSprite2
            // 
            this.downPipeSprite2.BackColor = System.Drawing.Color.Transparent;
            this.downPipeSprite2.Image = ((System.Drawing.Image)(resources.GetObject("downPipeSprite2.Image")));
            this.downPipeSprite2.Location = new System.Drawing.Point(53, -111);
            this.downPipeSprite2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downPipeSprite2.Name = "downPipeSprite2";
            this.downPipeSprite2.Size = new System.Drawing.Size(70, 533);
            this.downPipeSprite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipeSprite2.TabIndex = 5;
            this.downPipeSprite2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // initialChimneys
            // 
            this.initialChimneys.AutoSize = true;
            this.initialChimneys.Location = new System.Drawing.Point(432, 332);
            this.initialChimneys.Name = "initialChimneys";
            this.initialChimneys.Size = new System.Drawing.Size(50, 20);
            this.initialChimneys.TabIndex = 6;
            this.initialChimneys.Text = "label1";
            // 
            // startMove
            // 
            this.startMove.AutoSize = true;
            this.startMove.Location = new System.Drawing.Point(89, 332);
            this.startMove.Name = "startMove";
            this.startMove.Size = new System.Drawing.Size(0, 20);
            this.startMove.TabIndex = 7;
            // 
            // jumpButton
            // 
            this.jumpButton.BackColor = System.Drawing.Color.Transparent;
            this.jumpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpButton.Image = ((System.Drawing.Image)(resources.GetObject("jumpButton.Image")));
            this.jumpButton.Location = new System.Drawing.Point(145, 564);
            this.jumpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jumpButton.Name = "jumpButton";
            this.jumpButton.Size = new System.Drawing.Size(83, 43);
            this.jumpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jumpButton.TabIndex = 8;
            this.jumpButton.TabStop = false;
            this.jumpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jumpButton_MouseDown);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.Transparent;
            this.playGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playGameButton.Image = ((System.Drawing.Image)(resources.GetObject("playGameButton.Image")));
            this.playGameButton.Location = new System.Drawing.Point(126, 546);
            this.playGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(109, 61);
            this.playGameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playGameButton.TabIndex = 9;
            this.playGameButton.TabStop = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gameTitle.Location = new System.Drawing.Point(5, 164);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(350, 76);
            this.gameTitle.TabIndex = 10;
            this.gameTitle.Text = "FlappyBird";
            // 
            // gameTutorial
            // 
            this.gameTutorial.AutoSize = true;
            this.gameTutorial.BackColor = System.Drawing.Color.Transparent;
            this.gameTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTutorial.Location = new System.Drawing.Point(61, 510);
            this.gameTutorial.Name = "gameTutorial";
            this.gameTutorial.Size = new System.Drawing.Size(238, 31);
            this.gameTutorial.TabIndex = 11;
            this.gameTutorial.Text = "Click here to jump!";
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gameOverText.Location = new System.Drawing.Point(2, 332);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(356, 69);
            this.gameOverText.TabIndex = 12;
            this.gameOverText.Text = "Game Over!";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.ForeColor = System.Drawing.Color.Olive;
            this.scoreText.Location = new System.Drawing.Point(2, 641);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(159, 46);
            this.scoreText.TabIndex = 13;
            this.scoreText.Text = "Score 0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // yourScoreText
            // 
            this.yourScoreText.AutoSize = true;
            this.yourScoreText.BackColor = System.Drawing.Color.Transparent;
            this.yourScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yourScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.yourScoreText.Location = new System.Drawing.Point(37, 403);
            this.yourScoreText.Name = "yourScoreText";
            this.yourScoreText.Size = new System.Drawing.Size(287, 46);
            this.yourScoreText.TabIndex = 14;
            this.yourScoreText.Text = "Your score is 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.ClientSize = new System.Drawing.Size(361, 687);
            this.Controls.Add(this.yourScoreText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.gameTutorial);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.jumpButton);
            this.Controls.Add(this.birdSprite);
            this.Controls.Add(this.startMove);
            this.Controls.Add(this.initialChimneys);
            this.Controls.Add(this.downPipeSprite);
            this.Controls.Add(this.downPipeSprite2);
            this.Controls.Add(this.groundSprite);
            this.Controls.Add(this.upPipeSprite);
            this.Controls.Add(this.upPipeSprite2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birdSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipeSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipeSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipeSprite2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipeSprite2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGameButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox birdSprite;
        private PictureBox groundSprite;
        private PictureBox upPipeSprite;
        private PictureBox downPipeSprite;
        private PictureBox upPipeSprite2;
        private PictureBox downPipeSprite2;
        private System.Windows.Forms.Timer gameTimer;
        private Label initialChimneys;
        private Label startMove;
        private PictureBox jumpButton;
        private PictureBox playGameButton;
        private Label gameTitle;
        private Label gameTutorial;
        private Label gameOverText;
        private Label scoreText;
        private Label yourScoreText;
    }
}