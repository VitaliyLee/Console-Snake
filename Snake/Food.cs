using System;

namespace Snake
{
    class Food
    {
        public static Vector2 publicFoodPosition;

        private int x, y;
        public Vector2 Position { get => new Vector2(x, y); }
        public Food() => FoodPosition();


        public void Spawn(bool isSpawn)
        { 
            if (isSpawn)
            {
                FoodPosition();
            }
            
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }

        private void FoodPosition()
        {
            Random rnd = new Random();
            x = rnd.Next(0, Console.WindowWidth);
            y = rnd.Next(0, Console.WindowHeight);
            publicFoodPosition = new Vector2(x, y);
        }
    }
}
