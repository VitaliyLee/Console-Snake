using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    class Movement
    {
        private Vector2 direction;
        private int x, y;

        public Movement()
        {
            StartPosition();
        }

        public void Move()
        {
            SetDirection();
            Console.Clear();

            x += direction.x;
            y += direction.y;

            Console.SetCursorPosition(x, y);
            Console.Write("O");
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
    }
}
