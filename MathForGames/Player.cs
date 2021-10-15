﻿using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Player : Actor
    {
        private float _speed;
        private Vector2 _velocity;
        private int _playersOnTeam = 6;

        public int PlayersOnTeam
        {
            get { return _playersOnTeam; }
            set { _playersOnTeam = value; }
        }
        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Player(char icon, float x, float y, float speed, string name = "Actor", ConsoleColor color = ConsoleColor.White)
            : base(icon, x, y, name, color)
        {
            _speed = speed;
        }
        public override void Start()
        {
            base.Start();
            Velocity = new Vector2 { X = 2, Y = 2 };
        }
        public override void Update()
        {
            //Ball ball = new Ball();

            Vector2 moveDirection = new Vector2();

            ConsoleKey keyPressed = Engine.GetNextKey();

            if (keyPressed == ConsoleKey.A)
                moveDirection = new Vector2 { X = -1 };
            if (keyPressed == ConsoleKey.D)
                moveDirection = new Vector2 { X = 1 };
            if (keyPressed == ConsoleKey.W)
                moveDirection = new Vector2 { Y = -1 };
            if (keyPressed == ConsoleKey.S)
                moveDirection = new Vector2 { Y = 1 };
            //if (keyPressed == ConsoleKey.Spacebar)
              //  ball = new Ball { 'O', new Vector2 { X = 1, Y = 1 }, ConsoleColor.Cyan };

            Velocity = moveDirection * Speed;

            Position += Velocity;
        }
        /*
        public virtual bool ThrowBall()
        {
            ConsoleKey keyPressed = Engine.GetNextKey();

            if (keyPressed == ConsoleKey.Spacebar)
            {
                Ball ball = new Ball('O', new Vector2 { X = 1, Y = 1 }, ConsoleColor.Cyan);
                return true;
            }
            else
                return false;
        }
        */
        public override void OnCollision(Actor actor)
        {
            if (actor.Name == "Wall")
                Position -= Velocity;
            
            if (actor.Name == "Enemy")
                Engine.CloseApplication();
        }
    }
}
