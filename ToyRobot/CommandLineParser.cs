

using ToyRobot.Commands;

namespace ToyRobot
{
    public class CommandLineParser
    {
        public static ICommand Parse(string commandLine)
        {
            ICommand parsed = PlaceCommand.Parse(commandLine);
            if (parsed != null)
            {
                return parsed;
            }

            parsed = ReportCommand.Parse(commandLine);
            if (parsed != null)
            {
                return parsed;
            }
            
            parsed = MoveCommand.Parse(commandLine);
            if (parsed != null)
            {
                return parsed;
            }
            
            parsed = LeftCommand.Parse(commandLine);
            if (parsed != null)
            {
                return parsed;
            }

            return null;
        }
    }
}