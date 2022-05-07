using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Interfaces
{
    internal interface IMoveable
    {
        void Move();
        int Velocity { get; }
    }
}
