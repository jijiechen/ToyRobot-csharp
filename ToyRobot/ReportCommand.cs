namespace ToyRobot
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
            if (robot.Coordinate.Equals(Coordinate.Invalid) || robot.Direction == Direction.Invalid)
            {
                return null;
            }
            
            return $"{robot.Coordinate.X},{robot.Coordinate.Y},{robot.Direction}".ToUpper();
        }
    }
}