using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Interfaces;

namespace FlappyBird.Objects
{
    internal class Chimney : GameObject, IMoveable
    {
        public Chimney(PictureBox sprite, Point position, int width, int height) : base(sprite, position, width, height)
        {
        }

        public int Velocity => 5; // Temporary value

        public void Move()
        {
            // Chimney move to the left of the screen
            _position = new Point(Position.X - Velocity, Position.Y);

            OnChangePosition();
        }

        public override void Update()
        {
        }
    }
}
