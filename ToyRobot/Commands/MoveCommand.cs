using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class MoveCommand : ICommand
    {
        public static ICommand Parse(string commandLine)
        {
            if (commandLine == "MOVE")
            {
                return new MoveCommand();
            }

            return null;
        }

        public string Execute(Robot robot)
        {
            throw new System.NotImplementedException();
        }
    }
}