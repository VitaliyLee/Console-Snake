using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        private static TimerCallback timeCB;
        private static int timerInterval = 250;
        private static Snake snake;
        private static Food food;

        private static void Main(string[] args)
        {
            snake = new Snake();
            food = new Food();

            timeCB = new TimerCallback(Update);
            Timer time = new Timer(timeCB, null, 0, timerInterval);
            
            Input.Inputs();

            Console.ReadLine();
        }

        private static void Update(object state)
        {
            Console.Clear();
            Console.CursorVisible = false;

            snake.SnakeMove();
            food.Spawn(snake.Eating(food.Position));
        }
    }
}
