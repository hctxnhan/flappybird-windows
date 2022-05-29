using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.Interfaces;

namespace FlappyBird.Objects
{
    internal abstract class GameObject
    {
        protected Point _position;
        protected Rectangle _rectangle;
        protected PictureBox _sprite;
        protected bool _isRigid;

        public Rectangle Rectangle
        {
            get => _rectangle;
        }

        public Point Position
        {
            get => _position;
        }

        public bool IsRigid
        {
            get => _isRigid;
        }

        public GameObject(PictureBox sprite, Point position, int width, int height)
        {
            _sprite = sprite;
            _position = position;
            _rectangle = new Rectangle(position.X, position.Y, width, height);
        }

        public bool IsCollideWith(GameObject obj)
        {
            return _rectangle.IntersectsWith(obj.Rectangle);
        }

        public bool IsVisible()
        {
            return Position.X + Rectangle.Width > 0;
        }
        
        public void SetPosition(Point position)
        {
            _position = position;
            OnChangePosition();
        }

        public void OnChangePosition()
        {
            _sprite.Location = _position;
            _rectangle.Location = _position;
        }

        public abstract void Update();
    }
}
