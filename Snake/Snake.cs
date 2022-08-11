using System;

namespace Snake
{
    class Snake
    {
        private Movement movement;

        public Snake()
        {
            movement = new Movement();
        }

        public void SnakeMove()
        {
            movement.Move();
        }
    }
}
