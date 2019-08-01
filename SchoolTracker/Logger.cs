using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    class Logger
    {
        const string DefualtSystemName = "SchoolTracker";
        public static void Log(string msg, string system = DefualtSystemName, int priority = 1)
        {
            Console.WriteLine($"System: {system}, Priority: {priority}, Msg: {msg}");
        }
    }
}
