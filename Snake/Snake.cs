using System;
using System.Collections.Generic;

namespace Snake
{
    class Snake
    {
        private int snakeLength = 10;
        
        private Movement movement;
        private Vector2 currentHeadPos;

        public Snake()
        {
            movement = new Movement();
        }

        public void SnakeMove()
        {
            currentHeadPos = movement.Move("X", snakeLength);
            TailMove();
        }

        public bool Eating(Vector2 foodPosition)
        {
            if (currentHeadPos == foodPosition)
            {
                snakeLength++;
                return true;
            }

            return false;
        }

        private void TailMove()
        {
            for (int i = 1; i < snakeLength; i++)
            {
                Vector2 tailNextElementPos = BordDetection(currentHeadPos -= movement.Direction);
                Console.SetCursorPosition(tailNextElementPos.x, tailNextElementPos.y);
                Console.Write("О");
            }
        }

        private Vector2 BordDetection(Vector2 position)
        {
            if (position.x < 0) position.x += Console.WindowWidth + 1 - movement.Direction.x;
            if (position.x > Console.WindowWidth - 1) position.x += movement.Direction.x; //Тут допущена ошибка

            if (position.y < 0) position.y = Console.WindowHeight - 1;
            if (position.y > Console.WindowHeight - 1) position.y = 0;

            return position;
        }
    }
}
