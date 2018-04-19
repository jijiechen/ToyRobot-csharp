using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class RightCommand : ICommand
    {
        public static RightCommand Parse(string commandline)
        {
            if (commandline == "RIGHT")
            {
                return new RightCommand();
            }
            
            return null;
        }

        public string Execute(Robot robot)
        {
            if (robot.IsInvalid())
            {
                return null;
            }
            
            int directionValue = (int) robot.Direction;
            directionValue -= 90;
            if (directionValue < 0)
            {
                directionValue = 270;
            }
            
            robot.PlaceAt(robot.Coordinate, (Direction)directionValue);
            return null;
        }
    }
}