using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Interfaces;
namespace FlappyBird.Objects
{

    internal class Bird : GameObject, IMoveable
    {
        public Bird(PictureBox sprite, Point position, int width, int height) : base(sprite, position, width, height)
        {
        }

        public int Velocity => _velocity; // Temporary velocity for testing
        private int _gravity = 20;
        private int _velocity = 30;
        private int _currentVelocity = 0;
        public void Move()
        {
            _currentVelocity = _velocity;
        }

        public override void Update()
        {
            if (_currentVelocity < 0)
            {
                _currentVelocity = 0;
            }
            _currentVelocity -= 1;
            _position.Y += _gravity - _currentVelocity;
            OnChangePosition();
        }

        public bool IsAlive { get;}
    }
}
