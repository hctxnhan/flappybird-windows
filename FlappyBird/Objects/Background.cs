using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Interfaces;

namespace FlappyBird.Objects
{
    internal class Background : GameObject
    {
        public Background(PictureBox sprite, Point position, int width, int height) : base(sprite, position, width, height)
        {
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
