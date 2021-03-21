using System;

namespace UdemyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            Console.WriteLine("Press Space to start and stop the stopwatch or Escape to end.");
            while (key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                    watch.Toggle();
            }
        }
    }
}