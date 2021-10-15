using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Ball : Actor
    {
        private char _icon;
        private Vector2 _velocity;
        private ConsoleColor _color;
        private Vector2 _position;
        //private bool _hitTarget = false;

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Ball(char icon, Vector2 position, string name, ConsoleColor color = ConsoleColor.White) : base(icon, position, name, color)
        {
            
        }

        public override void Update()
        {
            _position.X = Position.X + 1;
        }

    }
}
