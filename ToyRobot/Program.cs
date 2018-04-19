using System;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLineExecutor.Execute(Console.In, Console.Out);
        }
    }
}
