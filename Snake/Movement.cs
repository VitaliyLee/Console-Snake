using System;
using System.Collections.Generic;

namespace Snake
{
    class Movement
    {
        private Vector2 direction;
        private Vector2 currentPosition;
        private int x, y;

        public Vector2 Direction { get => direction; }

        public Movement()
        {
            StartPosition();
        }

        public Vector2 Move(string SnakeBody, List<Vector2> SnakeTailPos)
        {
            SetDirection();

            x += direction.x;
            y += direction.y;

            currentPosition = new Vector2(x, y);

            BordDetection();
            
            Console.SetCursorPosition(x, y);
            Console.Write(SnakeBody);
            //TailMove(SnakeBody, SnakeTailPos);

            return currentPosition;
        }

        private void TailMove(string TailBody, List<Vector2> TalePos)
        {
            for (int i = 1; i < TalePos.Count; i++)
            {
                TalePos[i] += direction;

                Console.SetCursorPosition(TalePos[i - 1].x, TalePos[i - 1].y);
                Console.Write(TailBody);
            }
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
            Random rnd = new Random();
            x = rnd.Next(0, Console.WindowWidth);
            y = rnd.Next(0, Console.WindowHeight);
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
