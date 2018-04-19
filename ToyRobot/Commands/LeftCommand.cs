using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class LeftCommand : ICommand
    {
        public static LeftCommand Parse(string commandline)
        {
            if (commandline == "LEFT")
            {
                return new LeftCommand();
            }
            
            return null;
        }

        public string Execute(Robot robot)
        {
            throw new System.NotImplementedException();
        }
    }
}