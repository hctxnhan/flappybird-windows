using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Objects
{
    internal class Chimneys
    {
        private Chimney _upChimney;
        private Chimney _downChimney;

        const int DISTANCE_BETWEEN_CHIMNEYS = 500;

        public Chimneys(Chimney upChimney, Chimney downChimney)
        {
            _upChimney = upChimney;
            _downChimney = downChimney;
        }

        public void SetPosition(Point position)
        {
            int x = position.X;
            int y = position.Y;
            _downChimney.SetPosition(new Point(x, y - DISTANCE_BETWEEN_CHIMNEYS));
            _upChimney.SetPosition(position);
        }

        public void Move()
        {
            _upChimney.Move();
            _downChimney.Move();
        }

        public Point GetPosition()
        {
            return _upChimney.Position;
        }

        public bool IsDisplay()
        {
            return _upChimney.IsVisible() || _downChimney.IsVisible();
        }
    }
}
