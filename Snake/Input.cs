using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Input
    {
        private static ConsoleKey buttonPressed;

        public static void Inputs()
        {
            do
            {
                if (Console.KeyAvailable)
                {
                    buttonPressed = Console.ReadKey(true).Key;
                }
            }
            while (buttonPressed != ConsoleKey.Escape);
        }

        public static bool GetButtonDown(ConsoleKey Key)
        {
            if (buttonPressed == Key) return true;
            return false;
        }
    }
}
