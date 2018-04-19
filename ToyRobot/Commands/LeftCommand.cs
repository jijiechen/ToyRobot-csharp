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
            if (robot.IsInvalid())
            {
                return null;
            }
            
            int directionValue = (int) robot.Direction;
            directionValue += 90;
            if (directionValue >= 360)
            {
                directionValue = 0;
            }
            
            
            robot.PlaceAt(robot.Coordinate, (Direction)directionValue);
            return null;
        }
    }
}