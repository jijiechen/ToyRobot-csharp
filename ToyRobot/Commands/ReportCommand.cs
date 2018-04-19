using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class ReportCommand : ICommand
    {
        public static ReportCommand Parse(string input)
        {
            if(input == "REPORT")
                return new ReportCommand();

            return null;
        }

        public string Execute(Robot robot)
        {
            if (robot.IsInvalid())
            {
                return null;
            }
            
            return $"{robot.Coordinate.X},{robot.Coordinate.Y},{robot.Direction}".ToUpper();
        }
    }
}