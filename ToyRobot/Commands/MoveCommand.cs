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
            if (robot.IsInvalid())
            {
                return null;
            }
            
            var x = robot.Coordinate.X;
            var y = robot.Coordinate.Y;
            
            switch (robot.Direction)
            {
                case Direction.North:
                    y = y + 1;
                    break;
                case Direction.South:
                    y = y - 1;
                    break;
                case Direction.East:
                    x = x + 1;
                    break;
                case Direction.West:
                    x = x - 1;
                    break;
            }
            
            robot.PlaceAt(new Coordinate(x, y), robot.Direction);
            return null;
        }
    }
}