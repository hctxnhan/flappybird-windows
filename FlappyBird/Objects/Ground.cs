using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Interfaces;
namespace FlappyBird.Objects
{
    internal class Ground : GameObject, IMoveable
    {
        public Ground(PictureBox sprite, Point position, int width, int height) : base(sprite, position, width, height)
        {
        }

        public Point GroundDimension
        {
            get => new Point (_sprite.Width, _sprite.Height);
        }

        public int Velocity => 5;

        public void Move()
        {
            _position = new Point(Position.X - Velocity, Position.Y);
            OnChangePosition();
        }

        public override void Update()
        {
            Move();
        }
    }
}
