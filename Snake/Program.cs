using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    class Program
    {
        private static float timerInterval = 500;
        private static Snake snake;

        private static void Main(string[] args)
        {
            snake = new Snake();
            Behaviour.RunTimeCall(Update, timerInterval);
            Console.CursorVisible = false;
            Input.Inputs();

            Console.ReadLine();
        }

        private static void Update(object source, ElapsedEventArgs e)
        {
            snake.SnakeUpdate();

            
        }
    }
}
