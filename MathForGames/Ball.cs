using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Ball : Actor
    {
        private Vector2 _velocity;
        private Vector2 _position;
        private int _speed = 2;
        //private bool _hitTarget = false;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

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
            Vector2 direction = new Vector2();

            direction = new Vector2 { X = 1 };


            Velocity = Postion * Speed;
        }

    }
}
