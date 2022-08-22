using System;
using System.Collections.Generic;

namespace Snake
{
    class Movement
    {
        public static Vector2 publicHeadPosition;

        private Vector2 direction;
        private int x, y;

        public Vector2 Direction { get => direction; }

        public Movement()
        {
            StartPosition();
        }

        public Vector2 Move(string SnakeBody, int SnakeLength)
        {
            publicHeadPosition = new Vector2(x, y);
            SetDirection();

            x += direction.x;
            y += direction.y;

            BordDetection();
            
            Console.SetCursorPosition(x, y);
            Console.Write(SnakeBody);
            //TailMove(SnakeBody, SnakeTailPos);

            return new Vector2(x, y);
        }

        private void SetDirection()
        {
            if (Input.GetButtonDown(ConsoleKey.RightArrow) || Input.GetButtonDown(ConsoleKey.D)) direction = Vector2.right;

            if (Input.GetButtonDown(ConsoleKey.LeftArrow) || Input.GetButtonDown(ConsoleKey.A)) direction = Vector2.left;

            if (Input.GetButtonDown(ConsoleKey.DownArrow) || Input.GetButtonDown(ConsoleKey.S)) direction = -Vector2.down;

            if (Input.GetButtonDown(ConsoleKey.UpArrow) || Input.GetButtonDown(ConsoleKey.W)) direction = -Vector2.up;
        }

        private void StartPosition()
        {
            x = Console.WindowWidth -10;
            y = Console.WindowHeight / 2;
        }

        private void BordDetection()
        {
            if (x < 0) x = Console.WindowWidth - 1;
            if (x > Console.WindowWidth - 1) x = 0;

            if (y < 0) y = Console.WindowHeight - 1;
            if (y > Console.WindowHeight - 1) y = 0;
        }
    }
}
