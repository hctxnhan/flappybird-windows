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
            this.birdSprite.Location = new System.Drawing.Point(113, 204);
            this.birdSprite.Name = "birdSprite";
            this.birdSprite.Size = new System.Drawing.Size(52, 35);
            this.birdSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdSprite.TabIndex = 0;
            this.birdSprite.TabStop = false;
            // 
            // groundSprite
            // 
            this.groundSprite.Image = ((System.Drawing.Image)(resources.GetObject("groundSprite.Image")));
            this.groundSprite.Location = new System.Drawing.Point(-24, 461);
            this.groundSprite.Name = "groundSprite";
            this.groundSprite.Size = new System.Drawing.Size(746, 79);
            this.groundSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundSprite.TabIndex = 1;
            this.groundSprite.TabStop = false;
            // 
            // upPipeSprite
            // 
            this.upPipeSprite.BackColor = System.Drawing.Color.Transparent;
            this.upPipeSprite.Image = global::FlappyBird.Properties.Resources.pipe_up_e1529716823406;
            this.upPipeSprite.Location = new System.Drawing.Point(206, 344);
            this.upPipeSprite.Name = "upPipeSprite";
            this.upPipeSprite.Size = new System.Drawing.Size(61, 400);
            this.upPipeSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipeSprite.TabIndex = 2;
            this.upPipeSprite.TabStop = false;
            // 
            // downPipeSprite
            // 
            this.downPipeSprite.BackColor = System.Drawing.Color.Transparent;
            this.downPipeSprite.Image = ((System.Drawing.Image)(resources.GetObject("downPipeSprite.Image")));
            this.downPipeSprite.Location = new System.Drawing.Point(206, -83);
            this.downPipeSprite.Name = "downPipeSprite";
            this.downPipeSprite.Size = new System.Drawing.Size(61, 400);
            this.downPipeSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipeSprite.TabIndex = 3;
            this.downPipeSprite.TabStop = false;
            // 
            // upPipeSprite2
            // 
            this.upPipeSprite2.BackColor = System.Drawing.Color.Transparent;
            this.upPipeSprite2.Image = global::FlappyBird.Properties.Resources.pipe_up_e1529716823406;
            this.upPipeSprite2.Location = new System.Drawing.Point(46, 344);
            this.upPipeSprite2.Name = "upPipeSprite2";
            this.upPipeSprite2.Size = new System.Drawing.Size(61, 400);
            this.upPipeSprite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipeSprite2.TabIndex = 4;
            this.upPipeSprite2.TabStop = false;
            // 
            // downPipeSprite2
            // 
            this.downPipeSprite2.BackColor = System.Drawing.Color.Transparent;
            this.downPipeSprite2.Image = ((System.Drawing.Image)(resources.GetObject("downPipeSprite2.Image")));
            this.downPipeSprite2.Location = new System.Drawing.Point(46, -83);
            this.downPipeSprite2.Name = "downPipeSprite2";
            this.downPipeSprite2.Size = new System.Drawing.Size(61, 400);
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
            this.initialChimneys.Location = new System.Drawing.Point(378, 249);
            this.initialChimneys.Name = "initialChimneys";
            this.initialChimneys.Size = new System.Drawing.Size(38, 15);
            this.initialChimneys.TabIndex = 6;
            this.initialChimneys.Text = "label1";
            // 
            // startMove
            // 
            this.startMove.AutoSize = true;
            this.startMove.Location = new System.Drawing.Point(78, 249);
            this.startMove.Name = "startMove";
            this.startMove.Size = new System.Drawing.Size(0, 15);
            this.startMove.TabIndex = 7;
            // 
            // jumpButton
            // 
            this.jumpButton.BackColor = System.Drawing.Color.Transparent;
            this.jumpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpButton.Image = ((System.Drawing.Image)(resources.GetObject("jumpButton.Image")));
            this.jumpButton.Location = new System.Drawing.Point(127, 423);
            this.jumpButton.Name = "jumpButton";
            this.jumpButton.Size = new System.Drawing.Size(73, 32);
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
            this.playGameButton.Location = new System.Drawing.Point(113, 409);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(95, 46);
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
            this.gameTitle.Font = new System.Drawing.Font("Flappy Bird", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gameTitle.Location = new System.Drawing.Point(46, 123);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(226, 50);
            this.gameTitle.TabIndex = 10;
            this.gameTitle.Text = "FlappyBird";
            // 
            // gameTutorial
            // 
            this.gameTutorial.AutoSize = true;
            this.gameTutorial.BackColor = System.Drawing.Color.Transparent;
            this.gameTutorial.Font = new System.Drawing.Font("Flappy Bird", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTutorial.Location = new System.Drawing.Point(92, 403);
            this.gameTutorial.Name = "gameTutorial";
            this.gameTutorial.Size = new System.Drawing.Size(149, 17);
            this.gameTutorial.TabIndex = 11;
            this.gameTutorial.Text = "Click here to jump!";
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameOverText.Font = new System.Drawing.Font("Flappy Bird", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gameOverText.Location = new System.Drawing.Point(28, 249);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(262, 50);
            this.gameOverText.TabIndex = 12;
            this.gameOverText.Text = "Game Over!";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Flappy Bird", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.scoreText.Location = new System.Drawing.Point(12, 20);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(91, 25);
            this.scoreText.TabIndex = 13;
            this.scoreText.Text = "Score 0";
            // 
            // yourScoreText
            // 
            this.yourScoreText.AutoSize = true;
            this.yourScoreText.BackColor = System.Drawing.Color.Transparent;
            this.yourScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourScoreText.Font = new System.Drawing.Font("Flappy Bird", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yourScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.yourScoreText.Location = new System.Drawing.Point(70, 302);
            this.yourScoreText.Name = "yourScoreText";
            this.yourScoreText.Size = new System.Drawing.Size(178, 25);
            this.yourScoreText.TabIndex = 14;
            this.yourScoreText.Text = "Your score is 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.ClientSize = new System.Drawing.Size(316, 515);
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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