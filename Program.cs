using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new MyStopWatch();
            Run(stopWatch);
        }

        public static void Run(MyStopWatch stopWatch)
        {
            Console.WriteLine("***StopWatch App***");

            Console.WriteLine("-----------------------");
            Console.WriteLine("StopWatch Commands: ");
            Console.WriteLine("<START> - starts the SW");
            Console.WriteLine("<STOP> - stops the SW");
            Console.WriteLine("<RESET> - resets the SW");
            Console.WriteLine("<EXIT> - exits the SW");
            Console.WriteLine("-----------------------");

            while (true)
            {
                try
                {
                    Console.Write("[StopWatch]: ");
                    var input = Console.ReadLine();
                    if (input.Trim().ToLower() == "start")
                    {
                        stopWatch.Start();
                        Console.WriteLine("[StopWatch] <STARTED>");
                    }
                    else if (input.Trim().ToLower() == "stop")
                    {
                        stopWatch.Stop();
                        Console.WriteLine("[StopWatch] <STOPPED>");
                        Console.WriteLine("[StopWatch] Duration: " + stopWatch.Duration + " seconds");
                    }
                    else if (input.Trim().ToLower() == "reset")
                    {
                        stopWatch.Reset();
                        Console.WriteLine("[StopWatch] <RESET>");
                        Console.WriteLine("[StopWatch] Duration: " + stopWatch.Duration + " seconds");
                    }
                    else if (input.Trim().ToLower() == "exit")
                    {
                        Console.WriteLine("[StopWatch] <SHUTTING DOWN>");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("[StopWatch] <INVALID COMMAND>");
                    }
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error.Message);
                }
            }
        }
    }
}
