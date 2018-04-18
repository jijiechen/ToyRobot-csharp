namespace ToyRobot
{
    public class RobotOperator
    {
        private readonly Robot _robot;

        public RobotOperator(Robot robot)
        {
            _robot = robot;
        }


        public void HandleCommand(PlaceCommand command)
        {
            _robot.PlaceAt(new Coordinate(command.X, command.Y), command.Direction);
        }
        
        
        public string HandleCommand(ReportCommand command)
        {
            if (_robot.Coordinate.Equals(Coordinate.Invalid) || _robot.Direction == Direction.Invalid)
            {
                return string.Empty;
            }
            
            return $"{_robot.Coordinate.X},{_robot.Coordinate.Y},{_robot.Direction}";
        }
    }
}