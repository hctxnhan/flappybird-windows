using FlappyBird.Manager;
using FlappyBird.Objects;
namespace FlappyBird
{
    public partial class MainForm : Form
    {
        private GameManager _gameManager;
        private ChimneysManager _chimneysManager;
        private GroundManager _groundManager;

        public MainForm()
        {
            InitializeComponent();
            Bird bird = new Bird(this.birdSprite, this.birdSprite.Location, this.birdSprite.Width, this.birdSprite.Height);
            List<GameObject> obstacle = new List<GameObject>();
            Chimney chimneyUp1 = new Chimney(this.upPipeSprite, this.upPipeSprite.Location, this.upPipeSprite.Width, this.upPipeSprite.Height);
            Chimney chimneyUp2 = new Chimney(this.upPipeSprite2, this.upPipeSprite2.Location, this.upPipeSprite2.Width, this.upPipeSprite2.Height);
            Chimney chimneyDown1 = new Chimney(this.downPipeSprite, this.downPipeSprite.Location, this.downPipeSprite.Width, this.downPipeSprite.Height);
            Chimney chimneyDown2 = new Chimney(this.downPipeSprite2, this.downPipeSprite2.Location, this.downPipeSprite2.Width, this.downPipeSprite2.Height);
            Ground ground = new Ground(this.groundSprite, this.groundSprite.Location, this.groundSprite.Width, this.groundSprite.Height);
            obstacle.Add(chimneyUp1);
            obstacle.Add(chimneyUp2);
            obstacle.Add(chimneyDown1);
            obstacle.Add(chimneyDown2);
            obstacle.Add(ground);
            
            Chimneys chimneys1 = new Chimneys(chimneyUp1, chimneyDown1);
            Chimneys chimneys2 = new Chimneys(chimneyUp2, chimneyDown2);
            _chimneysManager = new ChimneysManager(chimneys1, chimneys2, this.initialChimneys.Location, this.startMove.Location);
            _gameManager = new GameManager(bird, obstacle);
            _groundManager = new GroundManager(ground);

            this.jumpButton.Visible = false;
            this.gameTutorial.Visible = false;
            this.gameOverText.Visible = false;
            this.scoreText.Visible = false;
            this.yourScoreText.Visible = false;

            _gameManager.GameStart += HideGameTutorial;
            _gameManager.GameOver += EndGameScreen;

            _chimneysManager.OnAvoidChimneys += _gameManager.OnAvoidObstacle;
            _chimneysManager.OnAvoidChimneys += UpdateScore;

            _gameManager.GameRestart += _chimneysManager.Reset;
            _gameManager.GameRestart += _groundManager.Reset;
            _gameManager.GameRestart += GameRestart;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (_gameManager.IsGameOver)
            {
                gameTimer.Stop();
                return;
            }

            _groundManager.Update();

            if (!_gameManager.IsGameStarted)
            {
                return;
            }

            _gameManager.Update();
            _chimneysManager.Update();
        }

        private void jumpButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _gameManager.OnKeyPressed();
            }
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            _gameManager.OnPlayKeyPressed();
            PlayGameScreen();
        }

        private void PlayGameScreen()
        {
            this.playGameButton.Visible = false;
            this.gameTitle.Visible = false;
            this.jumpButton.Visible = true;
            this.gameTutorial.Visible = true;
            this.scoreText.Visible = true;
            this.yourScoreText.Visible = false;
            this.gameOverText.Visible = false;
        }

        private void GameRestart()
        {
            this.scoreText.Text = "Score 0";
            this.gameTimer.Start();
        }

        private void EndGameScreen()
        {
            this.playGameButton.Visible = false;
            this.playGameButton.Visible = true;
            this.gameOverText.Visible = true;
            this.scoreText.Visible = false;

            this.yourScoreText.Text = "Your score is: " + _gameManager.Score.ToString();
            this.yourScoreText.Visible = true;
        }

        private void HideGameTutorial()
        {
            this.gameTutorial.Visible = false;
        }

        private void UpdateScore()
        {
            this.scoreText.Text = "Score: " + _gameManager.Score.ToString();
        }
    }
}