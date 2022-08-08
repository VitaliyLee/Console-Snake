using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        private Movement movement;

        public Snake()
        {
            movement = new Movement();
        }

        public void SnakeUpdate()
        {
            movement.Move();
        }
    }
}
