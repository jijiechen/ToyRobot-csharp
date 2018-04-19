using System.IO;

namespace ToyRobot
{
    public static class CommandLineExecutor
    {
        public static void Execute(TextReader ioIn, TextWriter ioOut)
        {
            var rebot = new Robot();
            
            string line;
            while(null != (line = ioIn.ReadLine()))
            {
                var command = CommandLineParser.Parse(line);
                if (command != null)
                {
                    var executeResult = command.Execute(rebot);
                    if (!string.IsNullOrEmpty(executeResult))
                    {
                        ioOut.WriteLine(executeResult);
                    }
                }
            }
            
        }
    }
}