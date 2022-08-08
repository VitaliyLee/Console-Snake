using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    public static class Behaviour
    {
        

        private static Timer timer;

        public static void RunTimeCall(ElapsedEventHandler ExecutableMethod, float DefoultTimerInterval)
        {
            timer = new Timer();
            timer.Interval = DefoultTimerInterval;
            timer.Elapsed += ExecutableMethod;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        
    }
}
