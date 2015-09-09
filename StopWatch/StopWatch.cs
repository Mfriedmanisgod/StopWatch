using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class StopWatchapp
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to STERPWARTCH!!!!");
            Console.WriteLine();
            Console.WriteLine("Please enter one of the following commands:");
            Console.WriteLine();
            Displaycommands();

            var stopwatch = System.Diagnostics.Stopwatch.StartNew(); // = new system.diagnostics.stopwatch stopwatch = new system.diagnostics.stopwatch?????
            stopwatch.Reset();
            
            bool Running = true;
            
            while(Running)
            {
                string userCommands = Console.ReadLine();
                userCommands = userCommands.ToLower(); 

                if (userCommands == "start")
                {
                    stopwatch.Start();
                    Console.WriteLine("The timer is rolling...type,'stop' to clock your time...");
                    Console.WriteLine();
                    Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                }
                
                else if (userCommands == "stop")
                {
                    stopwatch.Stop();
                    Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                }
                
                else if (userCommands == "reset")
                {
                    stopwatch.Reset();
                    Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                }
                
                else if (userCommands == "current time")
                {
                    Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                }
                
                else
                {
                    Console.WriteLine("Sorry, that command is not supported, Please enter one of the following:");
                    Console.WriteLine();
                    Displaycommands();
                }

             }
            
        }

        private void Displaycommands()
        {
            Console.WriteLine("START");
            Console.WriteLine();
            Console.WriteLine("STOP");
            Console.WriteLine();
            Console.WriteLine("RESET");
            Console.WriteLine();
            Console.WriteLine("CURRENT TIME");
            Console.WriteLine();
        }

    }
}
