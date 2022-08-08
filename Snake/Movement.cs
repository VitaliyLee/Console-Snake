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
        private int[] direction = new int[2];
        private int x, y;

        public Movement()
        {
            StartPosition();
        }

        public void Move()
        {
            SetDirection();
            Console.Clear();

            x += direction[0];
            y += direction[1];

            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        private void SetDirection()
        {
            if (Input.GetButtonDown(ConsoleKey.RightArrow)) direction = new int[] { 1, 0 };

            if (Input.GetButtonDown(ConsoleKey.LeftArrow)) direction = new int[] { -1, 0 };

            if (Input.GetButtonDown(ConsoleKey.DownArrow)) direction = new int[] { 0, 1 };

            if (Input.GetButtonDown(ConsoleKey.UpArrow)) direction = new int[] { 0, -1 };
        }

        private void StartPosition()
        {
            Random rnd = new Random();
            x = rnd.Next(0, Console.WindowWidth);
            y = rnd.Next(0, Console.WindowHeight);
        }
    }
}
