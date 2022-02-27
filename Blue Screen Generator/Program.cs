using System;
using System.Diagnostics;

namespace Blue_Screen_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get all the "svchost" proccess.
            var processes = Process.GetProcessesByName("svchost");


            //Kill all of them
            foreach (var process in processes)
            {
                process.Kill();
            }


            //The easiest code ever.
        }
    }
}
