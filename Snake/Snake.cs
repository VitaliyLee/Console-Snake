using System.Collections.Generic;

namespace Snake
{
    class Snake
    {
        private List<Vector2> snakeTail;
        private Movement movement;
        private Vector2 currentHeadPos;

        public Snake()
        {
            movement = new Movement();
            snakeTail = new List<Vector2>();

            if (snakeTail.Count == 0) snakeTail.Add(currentHeadPos);
        }

        public void SnakeMove()
        {
            currentHeadPos = movement.Move("O", snakeTail);
        }

        public bool Eating(Vector2 foodPosition)
        {
            if (currentHeadPos == foodPosition)
            {
                SnakeGrowth();
                return true;
            }

            return false;
        }

        private void SnakeGrowth()
        {
            snakeTail.Add(snakeTail[snakeTail.Count - 1] -= movement.Direction);
        }
    }
}
