using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Objects;

namespace FlappyBird.Manager
{
    internal class ChimneysManager
    {
        private Chimneys _chimneys1;
        private Chimneys _chimneys2;
        private Point _start;

        private const int MAX_Y_POSITION = 400;
        private const int MIN_Y_POSITION = 100;

        private Point _end;

        public delegate void AvoidChimneys();
        public AvoidChimneys OnAvoidChimneys;

        public ChimneysManager(Chimneys chimneys1, Chimneys chimneys2, Point start, Point end)
        {
            _chimneys1 = chimneys1;
            _chimneys2 = chimneys2;

            _start = start;
            _end = end;
            _chimneys1.SetPosition(start);
            _chimneys2.SetPosition(new Point(start.X + 200, end.Y));
        }

        public void Reset()
        {
            _chimneys1.SetPosition(_start);
            _chimneys2.SetPosition(new Point(_start.X + 200, _end.Y));
        }

        public void Update()
        {
            Random random = new Random();
            if (!_chimneys1.IsDisplay())
            {
                Point reset = new Point(_start.X, random.Next(MIN_Y_POSITION, MAX_Y_POSITION));
                OnAvoidChimneys?.Invoke();
                _chimneys1.SetPosition(reset);
            }

            if (!_chimneys2.IsDisplay())
            {
                Point reset = new Point(_start.X, random.Next(MIN_Y_POSITION, MAX_Y_POSITION));
                OnAvoidChimneys?.Invoke();
                _chimneys2.SetPosition(reset);
            }

            _chimneys1.Move();
            _chimneys2.Move();
        }
    }
}
