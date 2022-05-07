using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Objects;

namespace FlappyBird.Manager
{
    internal class GameManager
    {
        private Bird _bird;
        private List<GameObject> _obstacle;
        private bool _isGameOver;
        private bool _isGameStarted;

        public delegate void GameOverEventHandler();
        public delegate void GameStartEventHandler();
        public delegate void GameRestartEventHandler();

        public event GameOverEventHandler GameOver;
        public event GameStartEventHandler GameStart;
        public event GameRestartEventHandler GameRestart;

        private Point _initBirdPosition;

        public bool IsGameOver
        {
            get => _isGameOver;
        }

        public bool IsGameStarted
        {
            get => _isGameStarted;
        }

        public GameManager(Bird bird, List<GameObject> obstacle)
        {
            this._bird = bird;
            this._obstacle = obstacle;

            GameStart += OnGameStart;
            GameOver += OnDead;
            GameRestart += Reset;

            _initBirdPosition = _bird.Position;
        }
        private int _score = 0;
        public int Score { get => _score; }
        public void OnKeyPressed()
        {
            if (!_isGameStarted)
            {
                GameStart?.Invoke();
            }
            else
            {
                _bird.Move();
            }
        }

        public void OnPlayKeyPressed()
        {
            if (_isGameStarted && _isGameOver)
            {
                GameRestart?.Invoke();
            }
        }

        public void OnDead()
        {
            _isGameOver = true;
        }

        public void OnGameStart()
        {
            _isGameStarted = true;
            _bird.Move();
        }

        public void OnAvoidObstacle()
        {
            _score++;
        }

        public void Reset()
        {
            _isGameOver = false;
            _isGameStarted = false;
            _score = 0;
            _bird.SetPosition(_initBirdPosition);
        }

        public void Update()
        {
            if (_isGameOver)
            {
                return;
            }

            _bird.Update();
            foreach (var item in _obstacle)
            {
                if (_bird.IsCollideWith(item))
                {
                    GameOver?.Invoke();
                    break;
                }
            }
        }
    }
}
