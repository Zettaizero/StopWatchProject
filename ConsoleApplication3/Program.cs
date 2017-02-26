using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Press the enter key or type \"start\" or \"stop\" to run the stopwatch: ");
                string input = Console.ReadLine();

                if (input == "start" || String.IsNullOrWhiteSpace(input)) { StopWatch.Start(); continue; }
                if (input == "stop") { StopWatch.Stop();
                    Console.WriteLine();
                    Console.WriteLine("Duration: " + StopWatch.CalculateInterval().ToString("ss") +" seconds."); }
            }
        }
    }
}