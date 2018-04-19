using System;
using System.IO;

namespace ToyRobot
{
    class Program
    {
        static int Main(string[] args)
        {
            TextReader ioIn;
            TextWriter ioOut;

            if (args.Length == 2)
            {
                var fileIn = args[0];
                var fileOut = args[1];

                if (!File.Exists(fileIn))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Error.WriteLine($"File '{fileIn}' does not exist.");
                    Console.ResetColor();
                    
                    return 1;
                }

                ioIn = new StreamReader(File.OpenRead(fileIn));
                ioOut = new StreamWriter(File.Create(fileOut));
            }
            else
            {
                Console.WriteLine("ToyRobot is now running in interactive mode. You can press Ctrl + C to exit.");
                Console.WriteLine("Please type in instructions and press ENTER:");
                
                ioIn = Console.In;
                ioOut = Console.Out;
            }

            using (ioOut)
            {
                CommandLineExecutor.Execute(ioIn, ioOut);
            }
            return 0;
        }
    }
}
