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
    }
}