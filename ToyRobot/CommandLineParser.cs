

namespace ToyRobot
{
    public class CommandLineParser
    {
        public static ICommand Parse(string commandLine)
        {
            var spacePosition = commandLine.IndexOf(' ');
            
            var prefix = commandLine.Substring(0, spacePosition);
            var command = commandLine.Substring(spacePosition + 1);
            if (prefix == "PLACE")
            {
                return PlaceCommand.Parse(command);
            }

            return null;
        }
    }
}