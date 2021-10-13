using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Ball
    {
        private char _icon;
        private Vector2 _velocity;
        private ConsoleColor _color;
        //private bool _hitTarget = false;

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Ball(char icon, float x, float y, ConsoleColor color = ConsoleColor.White)
        {
            _icon = icon;
            _color = color;
        }

        public virtual void Update()
        {
            _velocity.X = Velocity.X + 1;
        }

    }
}
