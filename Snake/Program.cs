using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        private static TimerCallback timeCB;
        private static int timerInterval = 250;
        private static Snake snake;

        private static void Main(string[] args)
        {
            snake = new Snake();

            timeCB = new TimerCallback(Update);
            Timer time = new Timer(timeCB, null, 0, timerInterval);

            Console.CursorVisible = false;
            Input.Inputs();

            Console.ReadLine();
        }

        private static void Update(object state)
        {
            snake.SnakeMove();
        }
    }
}
