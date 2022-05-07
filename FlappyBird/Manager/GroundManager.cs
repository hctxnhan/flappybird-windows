using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Objects;

namespace FlappyBird.Manager
{
    internal class GroundManager
    {
        Ground _ground;
        Point _initPosition;
        public GroundManager(Ground ground)
        {
            _ground = ground;
            _initPosition = _ground.Position;
        }

        public void Reset()
        {
            _ground.SetPosition(_initPosition);
        }

        public void Update()
        {
            _ground.Update();

            if (_ground.Position.X < 0 - _ground.GroundDimension.X/2)
            {
                _ground.SetPosition(_initPosition);
            }
        }
    }
}
